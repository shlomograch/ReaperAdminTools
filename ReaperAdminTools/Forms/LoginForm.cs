using System;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ReaperAdminTools.Properties;

namespace ReaperAdminTools
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            currentVersionToolStripLbl.Text = Resources._Current_Version_v0_0_1_0;
            //Updater update = new Updater();
            //update.Show();
            // Temporaryily set to dis-abled.
            //superAdminOptions.Enabled = false;
            //compensation.Enabled = false;
            //serverInformation.Enabled = false;
            forceClientUpdate.Enabled = false;
            stealthMode.Enabled = false;
        }

        private void reaperLogo_Click(object sender, EventArgs e)
        {
            var reaperHomePage = "https://www.reapergaming.network/";
            Process.Start(reaperHomePage);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Encryption encryption = new Encryption();
            var encryptedPassword = encryption.GetSha1Hash(passwordTxtBox.Text);
            passwordTxtBox.Text = encryptedPassword;

            LoginInformation login = new LoginInformation();
            login.adminUserName = userNameTxtBox.Text;
            

            //Updater update = new Updater();
            //update.Show();

            // Remember me checkbox checked
            if (rememberMeCheckBox.Checked)
            {
                Settings.Default.SessionAlive = true;
                Settings.Default.Username = userNameTxtBox.Text;
            }
            else
            {
                Settings.Default.SessionAlive = false;
            }

            // Super admin options checked
            // TODO: if user is superAdmin allow login, else return error
            if (superAdminOptions.Checked)
            {
                SuperAdminOptions superAdminOptionsForm = new SuperAdminOptions();
                superAdminOptionsForm.Show();
            }

            // Compensation form checked
            if ( compensation.Checked )
            {
                CompensationForm compensationForm = new CompensationForm();
                compensationForm.Show();
            }

            // Server Information checked
            if (serverInformation.Checked)
            {
                ServerInformationForm serverInformationForm = new ServerInformationForm();
                serverInformationForm.Show();
            }

            Connections connections = new Connections();
            // Temp connection information for testing
            string query = "SELECT * FROM admintools_logon WHERE AdminUsername='" + userNameTxtBox.Text +
                              "' AND AdminPassword='" + encryptedPassword + "'";

            connections.LoginConnection(query);
        }

        private void clearFormBtn_Click(object sender, EventArgs e)
        {
            userNameTxtBox.Text = "";
            passwordTxtBox.Text = "";
            rememberMeCheckBox.Checked = false;
            superAdminOptions.Checked = false;
            compensation.Checked = false;
            serverInformation.Checked = false;
            forceClientUpdate.Checked = false;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
