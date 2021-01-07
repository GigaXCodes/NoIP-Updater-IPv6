using System;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;

namespace NoIP_Updater.Networking
{
    /// <summary>
    /// Class <c>AdapterRetriever</c> gathers all available network adapters
    /// </summary>
    class AdapterRetriever
    {
        // Information on the adapters
        private readonly AdapterInfo _adapterInfo;

        // Holds the network interfaces
        private readonly NetworkInterface[] _networks;

        /// <summary>
        /// Constructor <c>AdapterRetriever</c> gets all adapters, interfaces and marks the active one
        /// </summary>
        public AdapterRetriever()
        {
            // Gather adapter Information
            _adapterInfo = new AdapterInfo();

            // Gather all network interfaces
            _networks = NetworkInterface.GetAllNetworkInterfaces();

            // Gather all adapters based on the adapter Information
            getAdapters();

            // Mark the active one
            getActive();
        }

        /// <summary>
        /// Get all adapters
        /// </summary>
        private void getAdapters()
        {
            int i = 0;
            foreach (NetworkInterface adapter in _networks)
            {
                Debug.WriteLine("Found adapter '" + adapter.Description + "' index " + i + " and ID " + adapter.Id);
                _adapterInfo.All.Add(new Tuple<int, string, string>(i, adapter.Id, adapter.Description));
                i++;
            }
        }

        /// <summary>
        /// Get the active adapter
        /// </summary>
        private void getActive()
        {
            var activeAdapter = _networks.First(x => x.NetworkInterfaceType != NetworkInterfaceType.Loopback
                    && x.NetworkInterfaceType != NetworkInterfaceType.Tunnel
                    && x.OperationalStatus == OperationalStatus.Up
                    && !x.Name.StartsWith("vEthernet"));
            Debug.WriteLine("Adapter " + activeAdapter.Description + " with id " + activeAdapter.Id + " marked as active");
            _adapterInfo.Active = activeAdapter.Id;
        }

        /// <summary>
        /// Get all interfaces
        /// </summary>
        /// <returns></returns>
        public NetworkInterface[] getInferfaces()
        {
            return _networks;
        }

        /// <summary>
        /// Getter for the AdapterInfo object
        /// </summary>
        /// <returns>Instance of AdapterInfo</returns>
        public AdapterInfo Info()
        {
            return _adapterInfo;
        }
    }
}
