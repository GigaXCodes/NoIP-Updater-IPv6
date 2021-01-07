namespace NoIP_Updater.API
{
    /// <summary>
    /// Class <c>APIResponse</c> is a response object for the <c>API</c> class
    /// </summary>
    class APIResponse
    {
        // Response ok or fail
        public bool Successful { get; set; }
        // Response from No-IP
        public string Information { get; set; }
    }
}
