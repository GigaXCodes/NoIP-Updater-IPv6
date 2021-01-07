using Microsoft.Win32;
using NoIP_Updater.Networking;
using System;
using System.Windows.Forms;

namespace NoIP_Updater
{
    public partial class Settings : Form
    {
        private Main frmMain;

        public Settings(Main frmMain)
        {
            // Initalise Main form instance
            this.frmMain = frmMain;
            InitializeComponent();
        }

        private void Settings_Load(object sender, System.EventArgs e)
        {
            // Retrieve all adapters and the active one
            AdapterRetriever adapterRetriever = new AdapterRetriever();
            AdapterInfo adapterInfo = adapterRetriever.Info();
            int activeIndex = -1;
            string[] adapters = new string[adapterInfo.All.Count];
            foreach (Tuple<int, string, string> singleAdapter in adapterInfo.All)
            {
                // Set active adapter if no settings were defined
                if (singleAdapter.Item2.Equals(adapterInfo.Active))
                    activeIndex = singleAdapter.Item1;
                adapters[singleAdapter.Item1] = singleAdapter.Item3;
            }

            // Populate adapters
            combox_adapt.Items.AddRange(adapters);

            // Load the settings
            cbox_run_background.Checked = Properties.Settings.Default.backgroundservice;
            cbox_autostart.Checked = Properties.Settings.Default.autostart;
            if(Properties.Settings.Default.adapter == -1)
            {
                combox_adapt.SelectedIndex = activeIndex;
            }
            else
            {
                combox_adapt.SelectedIndex = Properties.Settings.Default.adapter;
            }
            int methodIPv4 = Properties.Settings.Default.ipv4_dt_method;
            switch (methodIPv4)
            {
                case (1):
                    rbtn_remote_ipv4.Checked = true;
                    cbox_remote_alternate_ipv4.Checked = false;
                    break;
                case (2):
                    rbtn_remote_ipv4.Checked = true;
                    cbox_remote_alternate_ipv4.Checked = true;
                    break;
                case (3):
                    rbtn_local_net_adapter_ipv4.Checked = true;
                    break;
            }

            int methodIPv6 = Properties.Settings.Default.ipv6_dt_method;
            switch (methodIPv6)
            {
                case (1):
                    rbtn_remote_ipv6.Checked = true;
                    cbox_remote_alternate_ipv6.Checked = false;
                    break;
                case (2):
                    rbtn_remote_ipv6.Checked = true;
                    cbox_remote_alternate_ipv6.Checked = true;
                    break;
                case (3):
                    rbtn_local_net_adapter_ipv6.Checked = true;
                    break;
                case (4):
                    rbtn_wanip_adapter.Checked = true;
                    break;
                case (5):
                    rbtn_wanip_adapter_tmp.Checked = true;
                    break;
            }
        }

        private void saveSettings()
        {
            // Services & Autostart
            Properties.Settings.Default.backgroundservice = cbox_run_background.Checked;
            Properties.Settings.Default.autostart = cbox_autostart.Checked;

            // IPv4 Settings
            Properties.Settings.Default.adapter = combox_adapt.SelectedIndex;
            int methodIPv4 = 0;
            if (rbtn_remote_ipv4.Checked && !cbox_remote_alternate_ipv4.Checked)
            {
                methodIPv4 = 1;
            }
            else if(rbtn_remote_ipv4.Checked && cbox_remote_alternate_ipv4.Checked)
            {
                methodIPv4 = 2;
            }
            else if(rbtn_local_net_adapter_ipv4.Checked)
            {
                methodIPv4 = 3;
            }
            Properties.Settings.Default.ipv4_dt_method = methodIPv4;

            // IPv6 Settings
            int methodIPv6 = 0;
            if (rbtn_remote_ipv6.Checked && !cbox_remote_alternate_ipv6.Checked)
            {
                methodIPv6 = 1;
            }
            else if (rbtn_remote_ipv6.Checked && cbox_remote_alternate_ipv6.Checked)
            {
                methodIPv6 = 2;
            }
            else if (rbtn_local_net_adapter_ipv6.Checked)
            {
                methodIPv6 = 3;
            }
            else if (rbtn_wanip_adapter.Checked)
            {
                methodIPv6 = 4;
            }
            else if(rbtn_wanip_adapter_tmp.Checked)
            {
                methodIPv6 = 5;
            }
            Properties.Settings.Default.ipv6_dt_method = methodIPv6;

            // Autostart
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            string appName = "NoIP-Updater - IPv4 and IPv6";
            if (cbox_autostart.Checked)
                rk.SetValue(appName, "\"" + Application.ExecutablePath.ToString() + "\" -minimized");
            else
                rk.DeleteValue(appName, false);

            // Save properties
            Properties.Settings.Default.Save();
        }

        private void btn_save_Click(object sender, System.EventArgs e)
        {
            // Save the settings
            saveSettings();
            Close();
        }

        private void rbtn_local_net_adapter_CheckedChanged(object sender, EventArgs e)
        {
            // Disable alternative checkbox for IPv4 and IPv6
            if (rbtn_remote_ipv4.Checked)
            {
                cbox_remote_alternate_ipv4.Enabled = true;
            }
            else
            {
                cbox_remote_alternate_ipv4.Enabled = false;
            }
            if (rbtn_remote_ipv6.Checked)
            {
                cbox_remote_alternate_ipv6.Enabled = true;
            }
            else
            {
                cbox_remote_alternate_ipv6.Enabled = false;
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save the settings
            saveSettings();
        }
    }
}
