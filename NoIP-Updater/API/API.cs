using NoIP_Updater.Networking;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace NoIP_Updater.API
{
    /// <summary>
    /// Class <c>APICall</c> handles the communication between No-IP and the Software Client
    /// </summary>
    class APICall
    {
        // IPInfo response class
        public IPInfo ipInfo;

        // Main form
        private Form main;

        /// <summary>
        /// Constructor <c>APICall</c> assigns the main window instance.
        /// </summary>
        /// <param name="mainCall">Instance of the main window</param>
        public APICall(Form mainCall)
        {
            main = mainCall;
        }

        /// <summary>
        /// Sends a update request to the No-IP Server.
        /// </summary>
        /// <returns>Instance of APIResponse response class</returns>
        public APIResponse UpdateRequest()
        {
#if DEBUG
            // Return always good if in debug mode, so our client doesnt get blocked.
            return InterpretResponseCode("good");
#endif
            // Prepare all variables
            String username = Properties.Settings.Default.username;
            String password = Properties.Settings.Default.password;
            String hosts = Properties.Settings.Default.hosts.Replace('\n', ',');
            String ips = ipInfo.IPv4Address + "," + ipInfo.IPv6Address;
            String url = String.Format("http://dynupdate.no-ip.com/nic/update?hostname={0}&myip={1}", hosts, ips);
            String encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            var os = Environment.OSVersion;
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            var responseCode = "";

            // New WebRequest
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = "NoIP-Updater NoIPUpdater/"+ os.Version + "-" + version + " nomail";
                request.Proxy = null;
                request.Timeout = 5000;
                request.Headers.Add("Authorization", "Basic " + encoded);

                // Get response
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(dataStream))
                        {
                            // Save to variable
                            responseCode = reader.ReadToEnd();
                            Debug.WriteLine(responseCode);

                            // Return APIResponse
                            return InterpretResponseCode(responseCode);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Debug.WriteLine(ex.Message);

                // Return APIResponse
                return InterpretResponseCode(ex.Message);
            }
        }

        /// <summary>
        /// Interpretates the string as No-IP response.
        /// </summary>
        /// <param name="response">String. Response to be interpretated</param>
        /// <returns>Return instance of APIResponse response class</returns>
        private APIResponse InterpretResponseCode(String response)
        {
            // New instance of the APIResponse
            APIResponse NOIP_Response = new APIResponse();

            // Fail by default
            NOIP_Response.Successful = false;

            if (response.StartsWith("good"))
            {
                // DNS hostname update successful. Followed by a space and the IP address it was updated to.
                //
                // The IP address returned will be the IPv4 address, if an IPv4 is supplied.
                // If IPv4 and IPv6 are both supplied, both ips will be returned in a comma separated list. 
                // If only an IPv6 address is supplied, an IPv6 address(only) will be returned.
                NOIP_Response.Information = "DNS hostname update successful.";
                NOIP_Response.Successful = true;
            }
            else if(response.StartsWith("nochg"))
            {
                // IP address is current, no update performed. Followed by a space and the IP address that it is currently set to.
                //
                // The IP address returned will be the IPv4 address if an IPv4 is supplied.
                // If IPv4 and IPv6 are both supplied, both ips will be returned in a comma separated list.
                // If only an IPv6 address is supplied, an IPv6 address(only) will be returned.
                //
                // Note: Excessive nochg responses may result in your client being blocked. 
                NOIP_Response.Information = "IP address is current, no update performed.";
                NOIP_Response.Successful = true;
            }
            else if (response.StartsWith("nohost"))
            {
                // Hostname supplied does not exist under specified account, client exit and require user to enter new login credentials 
                // before performing an additional request.
                NOIP_Response.Information = "Hostname supplied does not exist.";
            }
            else if (response.StartsWith("badauth"))
            {
                // Invalid username password combination.
                NOIP_Response.Information = "Invalid username password combination.";
            }
            else if (response.StartsWith("badagent"))
            {
                // Client disabled. Client should exit and not perform any more updates without user intervention.
                //
                // Note: You must use the recommended User-Agent format specified when Submitting an Update, 
                // failure to follow the format guidelines may result in your client being blocked.
                NOIP_Response.Information = "Client disabled.";
            }
            else if (response.StartsWith("!donator"))
            {
                // An update request was sent, including a feature that is not available to that particular user such as offline options.
                NOIP_Response.Information = "Request was sent, including a feature that is not available.";
            }
            else if (response.StartsWith("abuse"))
            {
                // Username is blocked due to abuse. Either for not following our update specifications or disabled due to violation 
                // of the No-IP terms of service. 
                // Our terms of service can be viewed here. Client should stop sending updates.
                NOIP_Response.Information = "Username is blocked due to abuse.";
            }
            else if (response.StartsWith("911"))
            {
                // A fatal error on our side such as a database outage. Retry the update no sooner than 30 minutes.
                //
                // A 500 HTTP error may also be returned in case of a fatal error on our system at which point you should 
                // also retry no sooner than 30 minutes.
                NOIP_Response.Information =  "A fatal error on our side such as a database outage.";
            }
            else
            {
                // Other responses
                NOIP_Response.Information = response;
            }

            // Return the instance
            return NOIP_Response;
        }
    }
}
