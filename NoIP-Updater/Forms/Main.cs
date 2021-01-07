using NoIP_Updater.Networking;
using NoIP_Updater.API;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NoIP_Updater
{
    /// <summary>
    /// Class <c>Main</c> is the primary window to call
    /// </summary>
    public partial class Main : Form
    {
        // No-IP API
        private APICall _clientAPI;

        // Retrieve all IP-Addresses, remote or locally
        private IPInfoRetriever _ipRetriever;

        // Used for the Timer
        private DateTime startTime = DateTime.Now;

        // On settings change variable
        private bool settingsChanged = false;

        /// <summary>
        /// Constructor <c>Main</c> calls all required classes and draws the Main Form
        /// </summary>
        public Main(string parameter)
        {
            // Initiate API
            _clientAPI = new API.APICall(this);

            // Get IP Information
            _ipRetriever = new IPInfoRetriever();

            // Event handler on settings changed
            Properties.Settings.Default.SettingChanging += SettingChanging;

            // Initalise components
            InitializeComponent();

            // Hide tray icon
            notifyIconNoIP.Visible = false;

            // Draw pictureboxes round
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pb_status_acc.Width - 3, pb_status_acc.Height - 3);
            Region rg = new Region(gp);
            pb_status_acc.Region = rg;
            pb_status_hosts.Region = rg;
            pb_status_ipv4.Region = rg;
            pb_status_ipv6.Region = rg;

            // Show login form if incomplete account settings are given
            if (!validateLogin())
                showLogin();

            // Minimize app if required
            MinimizeApp(parameter);
        }

        /// <summary>
        /// Initiates all other methods required for the program to work.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The form event arguments.</param>
        private void Main_Load(object sender, EventArgs e)
        {
            // Status - Account
            verifyAccountSettings();

            // Status - Hosts
            updateHostCount();

            // Status - Update IP
            ipUpdater.Enabled = true;
            updateIPs();
        }

        /// <summary>
        /// Minimize app to systray at autostart
        /// </summary>
        /// <param name="parameter">String. Program parameter</param>
        public void MinimizeApp(string parameter)
        {
            if (parameter == "-minimized")
            {
                this.WindowState = FormWindowState.Minimized;
                notifyIconNoIP.Visible = true;
                notifyIconNoIP.BalloonTipText = "Program is started and running in the background...";
                notifyIconNoIP.ShowBalloonTip(500);
                ShowInTaskbar = false;
                Hide();
            }

        }

        /// <summary>
        /// Checks if the No-IP credentials are given
        /// </summary>
        /// <returns>Boolean</returns>
        public bool validateLogin()
        {
            if (Properties.Settings.Default.username == "" || Properties.Settings.Default.password == "")
            {
                // User has entered username and password, mark green
                pb_status_acc.BackColor = Color.Red;
                return false;
            }
            else
            {
                // User has left username or password empty, mark red
                pb_status_acc.BackColor = Color.Green;
                return true;
            }
        }

        /// <summary>
        /// Initiates the login window.
        /// </summary>
        public void showLogin()
        {
            Login frmLogin = new Login(this);
            frmLogin.ShowDialog();
        }

        /// <summary>
        /// Shows the settings window.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings frmSettings = new Settings(this);
            frmSettings.ShowDialog();
        }

        /// <summary>
        /// Shows the hosts window.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btn_hosts_Click(object sender, EventArgs e)
        {
            Hosts frmHosts = new Hosts(this);
            frmHosts.ShowDialog();
        }

        /// <summary>
        /// Shows the login window again for editing.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btn_acc_Click(object sender, EventArgs e)
        {
            showLogin();
        }

        /// <summary>
        /// Flushes the windows DNS-Cache manually.
        /// </summary>
        [DllImport("dnsapi.dll", EntryPoint = "DnsFlushResolverCache")]
        private static extern UInt32 DnsFlushResolverCache();
        private void flushDNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UInt32 result = DnsFlushResolverCache();
        }

        /// <summary>
        /// Minimizes to the tray.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Hide();
            WindowState = FormWindowState.Minimized;
            notifyIconNoIP.Visible = true;
        }

        /// <summary>
        /// Shows the main window again.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconNoIP.Visible = false;
        }

        /// <summary>
        /// Shows the main window if the tray icon has been double clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The mouse event arguments.</param>
        private void notifyIconNoIP_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconNoIP.Visible = false;
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Report changes of settings to the variable
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The settings changed event arguments.</param>
        public void SettingChanging(object sender, System.Configuration.SettingChangingEventArgs e)
        {
            settingsChanged = true;
        }

        /// <summary>
        /// Verifies the account settings if the main window was called already.
        /// </summary>
        public void verifyAccountSettings()
        {
            if (Properties.Settings.Default.username != "" && Properties.Settings.Default.password != "")
            {
                // Show the username so the user knows he is right
                l_status_acc.Text = Properties.Settings.Default.username;
            }
            else
            {
                // Tell the user to update his credentials
                l_status_acc.Text = "Please update your login details";
            }
        }

        /// <summary>
        /// Updates the displayed host count.
        /// </summary>
        public void updateHostCount()
        {
            // All hosts from settings
            string hosts = Properties.Settings.Default.hosts;

            // Split by new line
            int numLines = hosts.Split('\n').Length;
            if(String.IsNullOrEmpty(hosts))
            {
                // No entrys
                numLines = 0;
                pb_status_hosts.BackColor = Color.Red;
            }
            else
            {
                // Has entrys
                pb_status_hosts.BackColor = Color.Green;
            }

            // Show number of hosts
            l_status_hosts.Text = numLines.ToString() + " hosts";
        }

        /// <summary>
        /// Updates all IP-Addresses, Labels and sends a request to No-IP
        /// </summary>
        /// <returns>IPInfo instance with all IPs from the selected Adapter</returns>
        public IPInfo updateIPs()
        {
            // Receive all IP-Addresses
            IPInfo ipInfo = _ipRetriever.getInfo();

            // If a IP has changed, update the No-IP account
            if (l_status_ipv4.Text != ipInfo.IPv4Address || l_status_ipv6.Text != ipInfo.IPv6Address)
            {
                // Temporary status
                l_status_ipv4.Text = "...";
                l_status_ipv6.Text = "...";

                // Initiate the No-IP API Class with the IPInfo instance
                _clientAPI.ipInfo = ipInfo;

                // Validate IPs
                if(ipInfo.IPv4Valid || ipInfo.IPv6Valid)
                {
                    // If it has one valid IP
                    Debug.WriteLine("Sending request to No-IP...");
                    APIResponse lastResponse = _clientAPI.UpdateRequest();
                    if (lastResponse.Successful)
                    {
                        // No-IP reported a sucessfull update of the IPs
                        pb_status_ipv4.BackColor = Color.Green;
                        pb_status_ipv6.BackColor = Color.Green;
                    }
                    else
                    {
                        // No-IP had a error
                        pb_status_ipv4.BackColor = Color.Red;
                        pb_status_ipv6.BackColor = Color.Red;
                    }

                    // Tell the user what No-IP said
                    l_status_log.Text = lastResponse.Information;
                }
                else
                {
                    // If it has not a single valid IP
                    pb_status_ipv4.BackColor = Color.Red;
                    pb_status_ipv6.BackColor = Color.Red;
                    l_status_log.Text = "Adapter has no valid IPv4 or IPv6 Address, please check your settings.";
                }

                // Report the specific status to the user for each IP-Protocoll
                l_status_ipv4.Text = ipInfo.IPv4Address;
                l_status_ipv6.Text = ipInfo.IPv6Address;
            }
            else
            {
                // No update required, so we dont send a request so our client doesnt get blocked
                l_status_log.Text = "IP address is current, no update performed.";
            }

            // The time has come
            startTime = DateTime.Now;

            // Return the IPInfo object for further processing
            return ipInfo;
        }

        /// <summary>
        /// Timer to update the IPs every 5 minutes.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ipUpdater_Tick(object sender, EventArgs e)
        {
            // 5 minutes from the start time
            l_status_next_check.Text =
                    (TimeSpan.FromMinutes(5) - (DateTime.Now - startTime))
                    .ToString("hh\\:mm\\:ss");
            if (l_status_next_check.Text == "00:00:00" || settingsChanged)
            {
                // The time has come to update em all!
                settingsChanged = false;
                updateIPs();

                // Reset the timer
                startTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Updates all IPs manually. Warns the user if a minute not has passed yet.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            // Check if 1 minute has passed
            var passedTime = (TimeSpan.FromMinutes(5) - (DateTime.Now - startTime))
                    .TotalMinutes;
            if(passedTime > 4){

                // Warn the user
                MessageBox.Show("One minute has not been passed yet, do not manually update it too fast/often. This can get your client blocked.");
            }

            // Update all IPs
            IPInfo ipInfo = updateIPs();
            Debug.WriteLine("Refreshed IPv4 with new IP: " + ipInfo.IPv4Address);
            Debug.WriteLine("Refreshed IPv6 with new IP: " + ipInfo.IPv6Address);
        }

        /// <summary>
        /// Copy the IPv4 to the Clipboard
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void publicIPv4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(l_status_ipv4.Text);
        }

        /// <summary>
        /// Copy the IPv6 to the Clipboard
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void publicIPv6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(l_status_ipv6.Text);
        }

        /// <summary>
        /// Copy the IPv4 to the Clipboard (from the sys tray)
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void copyIPv4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(l_status_ipv4.Text);
        }

        /// <summary>
        /// Copy the IPv6 to the Clipboard (from the sys tray)
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void copyIPv6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(l_status_ipv6.Text);
        }
    }
}
