using System;
using System.Windows.Forms;

namespace NoIP_Updater
{
    /// <summary>
    /// Class <c>Login</c> is the first window called if the program is started the first time
    /// </summary>
    public partial class Login : Form
    {
        // Instance of the main window
        private Main frmMain;

        /// <summary>
        /// Constructor <c>Login</c> assigns the main window instance.
        /// </summary>
        /// <param name="frmMain">Main window object instance</param>
        public Login(Main frmMain)
        {
            this.frmMain = frmMain;
            InitializeComponent();
        }

        /// <summary>
        /// Saves the entered credentials to the settings.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.username = txt_username.Text;
            Properties.Settings.Default.password = txt_password.Text;
            Properties.Settings.Default.Save();
            frmMain.validateLogin();
            this.Close();
        }

        /// <summary>
        /// Load previous entered credentials.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Login_Load(object sender, EventArgs e)
        {
            txt_username.Text = Properties.Settings.Default.username;
            txt_password.Text = Properties.Settings.Default.password;
        }
    }
}
