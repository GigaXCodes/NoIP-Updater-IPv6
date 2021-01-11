﻿using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace NoIP_Updater.Networking
{
    /// <summary>
    /// Class <c>IPInfoRetriever</c> gathers all IPs via local or remote methods
    /// </summary>
    public class IPInfoRetriever
    {
        // Instance of the IPInfo response class
        private IPInfo _ipInfo;

        // Instance of the Adapter receiver class
        private AdapterRetriever _adapters;

        /// <summary>
        /// Constructor <c>IPInfoRetriever</c> initalises the IPInfo and Adapter objects
        /// </summary>
        public IPInfoRetriever()
        {
            // IP Information response instance
            _ipInfo = new IPInfo();

            // Adapter Information receiver instance
            _adapters = new AdapterRetriever();
        }

        /// <summary>
        /// Gathers the IPv4-Address either remote or locally
        /// </summary>
        public void refreshIPv4()
        {
            // Valid as default
            _ipInfo.IPv4Valid = true;

            // Detection method (Remote 1, Remote 2 or Local)
            int detectMethod = Properties.Settings.Default.ipv4_dt_method;
            if (detectMethod == 3)
            {
                if(_ipInfo.IPv4Local == null)
                {
                    // Adapter fail
                    Debug.WriteLine("Receiving the IPv4 Address was not possible, Adapter may faulty.");
                    _ipInfo.IPv4Address = "Adapter has no IPv4 Address";
                    _ipInfo.IPv4Valid = false;
                }
                else
                {
                    // Local IPv4
                    Debug.WriteLine("Using method 3 to receive the local IPv4");
                    _ipInfo.IPv4Address = _ipInfo.IPv4Local;
                    Debug.WriteLine("IPv4: " + _ipInfo.IPv4Address);
                }
            }
            else
            {
                // Remote IPv4
                _ipInfo.IPv4Address = getWanIPRemote(detectMethod);
            }
        }

        /// <summary>
        /// Gathers the IPv6-Address either remote or locally
        /// </summary>
        public void refreshIPv6()
        {
            // Valid as default
            _ipInfo.IPv6Valid = true;

            // Detection method (Remote 1, Remote 2, Local-Link, Static, Temporary)
            int detectMethod = Properties.Settings.Default.ipv6_dt_method;
            if (detectMethod == 1 || detectMethod == 2)
            {
                // Remote IPv6
                _ipInfo.IPv6Address = getWanIPRemote(detectMethod, true);
            }
            else
            {
                if (_ipInfo.IPv6Local == null) {
                    // Adapter fail
                    Debug.WriteLine("Receiving the IPv6 Address was not possible, Adapter may faulty.");
                    _ipInfo.IPv6Address = "Adapter has no IPv6 Address";
                    _ipInfo.IPv6Valid = false;
                }
                else
                {
                    switch (detectMethod)
                    {
                        // Link-Local
                        case (3):
                            Debug.WriteLine("Using method 3 to receive the link local adress");
                            if (!String.IsNullOrEmpty(_ipInfo.IPv6Local[2]))
                            {
                                _ipInfo.IPv6Address = _ipInfo.IPv6Local[2];
                            }
                            else
                            {
                                _ipInfo.IPv6Address = "Link local not found";
                                _ipInfo.IPv6Valid = false;
                            }
                            break;
                        // Static
                        case (4):
                            Debug.WriteLine("Using method 4 to receive the static IPv6");
                            if (!String.IsNullOrEmpty(_ipInfo.IPv6Local[0]))
                            {
                                _ipInfo.IPv6Address = _ipInfo.IPv6Local[0];
                            }
                            else
                            {
                                _ipInfo.IPv6Address = "No IPv6 Address found";
                                _ipInfo.IPv6Valid = false;
                            }
                            break;
                        // Temporary (generated by Windows)
                        case (5):
                            Debug.WriteLine("Using method 5 to receive the temporary IPv6");
                            if (!String.IsNullOrEmpty(_ipInfo.IPv6Local[1]))
                            {
                                _ipInfo.IPv6Address = _ipInfo.IPv6Local[1];
                            }
                            else
                            {
                                _ipInfo.IPv6Address = "No temporary IPv6 Address found";
                                _ipInfo.IPv6Valid = false;
                            }
                            break;
                    }
                    Debug.WriteLine("IPv6: " + _ipInfo.IPv6Address);
                }
            }
        }

        /// <summary>
        /// Refreshes all IP Addresses available for later use
        /// </summary>
        public void refreshAddresses()
        {
            // Retrieve local IPs
            getLocalIPs();

            // Retrieve IPv4 Address
            refreshIPv4();

            // Retrieve IPv6 Address
            refreshIPv6();
        }

        /// <summary>
        /// Getter Method for IPInfo instance
        /// </summary>
        /// <returns>Instance of IPInfo response class</returns>
        public IPInfo getInfo()
        {
            // Refresh all
            refreshAddresses();
            return _ipInfo;
        }

        /// <summary>
        /// Get IP-Address via remote server
        /// </summary>
        /// <param name="method">integer = 1 (IpIfy.org) | 2 (SeeIP.org)</param>
        /// <param name="IPv6">Get IPv6?</param>
        /// <returns>String. IP-Address</returns>
        private string getWanIPRemote(int method, bool IPv6 = false)
        {
            // All parameters
            string url = "";
            string urlExtra = "";
            string wanIp = "";
            string protocollVersion = IPv6 ? "IPv6" : "IPv4";
            if (method == 1)
            {
                if (IPv6) urlExtra = "6";
                url = "https://api" + urlExtra + ".ipify.org/";
            }
            else if(method == 2)
            {
                if(IPv6)
                {
                    urlExtra = "6";
                }
                else
                {
                    urlExtra = "4";
                }
                url = "https://ip" + urlExtra + ".seeip.org/";
            }
            Debug.WriteLine("Using method " + method + " for protocol "+ protocollVersion);

            // New WebRequest
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:76.0) Gecko/20100101 Firefox/76.0";
                request.Proxy = null;
                request.Timeout = 5000;

                // Get response
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(dataStream))
                        {
                            // Save to variable
                            wanIp = reader.ReadToEnd();
                            Debug.WriteLine(protocollVersion + ": " + wanIp + " (with URL " + url + ")");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle Exception
                Debug.WriteLine(ex.Message);
                wanIp = "Unknown";
                MessageBox.Show("Failed to get public IPv" + urlExtra + "-Address, please try alternative method.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Return variable
            return wanIp;
        }

        /// <summary>
        /// Get all local IPs from the interfaces
        /// </summary>
        private void getLocalIPs()
        {
            // Iritate each interface
            int ii = -1;
            foreach (var iface in _adapters.getInferfaces())
            {
                // If network is up, no loopback and the adapter the choosen one
                ii++;
                if (iface.OperationalStatus == OperationalStatus.Up && iface.NetworkInterfaceType != NetworkInterfaceType.Loopback && Properties.Settings.Default.adapter == ii /*&& iface.Id == adapter.Active*/)
                {
                    // Build IPv6 Array
                    _ipInfo.IPv6Local = new string[4];
                    int i = 0;

                    // Each unicast address
                    foreach (var ua in iface.GetIPProperties().UnicastAddresses)
                    {
                        // Parse IPAddress object
                        IPAddress parsedIP = ua.Address;

                        // If is IPv6 protocoll
                        if (parsedIP.AddressFamily == AddressFamily.InterNetworkV6)
                        {
                            // Save all found addresses to the array
                            string IPv6Address = parsedIP.ToString();
                            int index = IPv6Address.IndexOf("%");
                            if (index > 0)
                                IPv6Address = IPv6Address.Substring(0, index);
                            _ipInfo.IPv6Local[i++] = IPv6Address;
                        }

                        // If is IPv4 protocoll
                        if (parsedIP.AddressFamily == AddressFamily.InterNetwork)
                            _ipInfo.IPv4Local = parsedIP.ToString();

                        Debug.WriteLine("Found local " + parsedIP.AddressFamily + ": " + parsedIP + " with Interface " + iface.Description + " (" + iface.Id + ")");
                    }
                }
            }
        }
    }
}