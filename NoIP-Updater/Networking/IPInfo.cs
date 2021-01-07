namespace NoIP_Updater.Networking
{
    /// <summary>
    /// Class <c>IPInfo</c> is a response object for the <c>IPInfoRetriever</c> class
    /// </summary>
    public class IPInfo
    {
        // IPv4 Address
        public string IPv4Address { get; set; }
        // Is the IPv4 valid?
        public bool IPv4Valid { get; set; }
        // Local IPv4 Address
        public string IPv4Local { get; set; }
        // IPv6 Address
        public string IPv6Address { get; set; }
        // Is the IPv6 valid?
        public bool IPv6Valid { get; set; }
        // Local IPv6 Address
        public string[] IPv6Local { get; set; }
    }
}