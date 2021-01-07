using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NoIP_Updater
{
    /// <summary>
    /// Class <c>Hosts</c> is called to define the hosts to update
    /// </summary>
    public partial class Hosts : Form
    {
        // Instance of the main window
        private Main frmMain;

        /// <summary>
        /// Constructor <c>Hosts</c> assigns the main window instance.
        /// </summary>
        /// <param name="frmMain">Main window object instance</param>
        public Hosts(Main frmMain)
        {
            // Get main form and initalise
            this.frmMain = frmMain;
            InitializeComponent();
        }

        /// <summary>
        /// Removes all empty new lines
        /// </summary>
        /// <param name="text">Text with empty lines</param>
        /// <returns>Text without empty lines</returns>
        private string removeEmptyLines(string text)
        {
            return Regex.Replace(text, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).TrimEnd();
        }

        /// <summary>
        /// Removes all whitespaces
        /// </summary>
        /// <param name="text">Text with whitespaces</param>
        /// <returns>Text without whitespaces</returns>
        private string removeWhitespace(string text)
        {
            return Regex.Replace(text.Trim(), @"[^\S\r\n]+", "");
        }

        /// <summary>
        /// Search for valid domain names without scheme
        /// </summary>
        /// <param name="url">String containing the url</param>
        /// <returns>Boolean. Is valid domain</returns>
        private static bool isValidDomain(string url)
        {
            var match =  Regex.Match(url, @"^((?!http(s)?:\/\/).)?([\w-]+\.)+[\w-]+(/[\w- ;,./?%&=]*)?", RegexOptions.Multiline);
            if(!match.Success)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Validate the user input
        /// </summary>
        /// <returns>Boolean. User input was valid.</returns>
        private bool validateInput()
        {
            // Remove unnecessary lines
            rtxt_list.Text = removeEmptyLines(removeWhitespace(rtxt_list.Text));

            // Check if valid domains
            using (StringReader reader = new StringReader(rtxt_list.Text))
            {
                string urlLine;
                while ((urlLine = reader.ReadLine()) != null)
                {
                    if (!isValidDomain(urlLine))
                        return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Called to save it and close the window
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            //Validate the input
            if(!validateInput())
            {
                MessageBox.Show("One of the domains is not valid, please check your input.", "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Save settings
                Properties.Settings.Default.hosts = rtxt_list.Text;
                Properties.Settings.Default.Save();

                //Update host count and close
                frmMain.updateHostCount();
                this.Close();
            }
        }

        /// <summary>
        /// Initiates the hosts window.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The form event arguments.</param>
        private void Hosts_Load(object sender, EventArgs e)
        {
            // Load hosts from settings
            rtxt_list.Text = Properties.Settings.Default.hosts;
        }
    }
}
