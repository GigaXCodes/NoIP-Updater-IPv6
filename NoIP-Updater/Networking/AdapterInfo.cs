using System;
using System.Collections.Generic;

namespace NoIP_Updater.Networking
{
    /// <summary>
    /// Class <c>AdapterInfo</c> is a response object for the <c>AdapterRetriever</c> class
    /// </summary>
    class AdapterInfo
    {
        // All adapters found as int, string, string array
        public List<Tuple<int, string, string>> All = new List<Tuple<int, string, string>>();
        // Variable that holdes the active adapter id
        public string Active { get; set; }
    }
}
