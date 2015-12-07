using System;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

using ReaperAdminTools.Properties;

namespace ReaperAdminTools
{
    public partial class SuperAdminOptions : Form
    {
        public SuperAdminOptions()
        {
            InitializeComponent();
        }

        private void SuperAdminOptions_Load(object sender, EventArgs e)
        {
            RefreshComboBoxs();
        }

        private void addAnAdminBtn_Click(object sender, EventArgs e)
        {
            Connections connections = new Connections();
            Encryption encryption = new Encryption();

            var encryptedPassword = encryption.GetSha1Hash( addAnAdminPassword.Text );
            
            if ( addAnAdminUserName.Text != "" && addAnAdminUserName.Text.Length > 3
                 && addAnAdminPassword.Text != "" && addAnAdminPassword.Text.Length > 3 )
            {
                
            }
            
            // whitelist controls for new user
            var canWhiteListCop = "0";
            var canWhiteListMed = "0";

            // Restrictions for new user
            var kickingRestricted = "0";
            var banningRestricted = "0";
            var compensationRestricted = "0";
            var whiteListingRestricted = "0";
            var garageViewRestricted = "0";
            var garageCompRestricted = "0";
            var canUseMarquee = "0";
            var isSuperAdmin = "0";



            if ( restrictKicking.Checked )
            {
                kickingRestricted = "1";
            }

            if ( restrictBanning.Checked )
            {
                banningRestricted = "1";
            }

            if ( restrictCompensation.Checked )
            {
                compensationRestricted = "1";
            }

            if ( restrictWhitelisting.Checked )
            {
                whiteListingRestricted = "1";
            }

            if ( restrictGarageView.Checked )
            {
                garageViewRestricted = "1";
            }

            if ( restrictGarageComp.Checked )
            {
                garageCompRestricted = "1";
            }

            if ( restrictMarquee.Checked )
            {
                canUseMarquee = "1";
            }

            if ( restrictSuperAdmin.Checked )
            {
                isSuperAdmin = "1";
            }

            string query = "INSERT INTO admintools_logon (AdminUsername, AdminPassword) VALUES  ('" + addAnAdminUserName.Text + "', '" + encryptedPassword + "')";

            // Change Admin Guid to use AdminGuid not test value
            //string restrictionsQuery = "INSERT INTO admintools_restrictions (AdminName, AdminRestrictKicking, AdminRestrictBanning, AdminRectrictCompensation, " +
            //                           "AdminRestrictWhiteListing, AdminRestrictGarageView, AdminRestrictGarageComp, AdminRestrictMarquee) "+
            //                           "VALUES ('" + addAnAdminUserName.Text + ", " + kickingRestricted + ", " + banningRestricted + ", " + compensationRestricted + ", " + whiteListingRestricted + ", "
            //                           + garageViewRestricted + ", " + garageCompRestricted + ", " + canUseMarquee + "')";
            //
            //connections.RunScript(restrictionsQuery);
            connections.RunScript( query );
            
            RefreshComboBoxs();
            ClearAddAUserTab();
        }

        private void modifyAnAdminUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connections connection = new Connections();
            connection.PopulateSuperAdminModifyAdmin(modifyAnAdminUsername.SelectedText);
        }

        private void modifyAnAdminModifyBtn_Click(object sender, EventArgs e)
        {
            Connections connection = new Connections();
            connection.PopulateSuperAdminModifyAdmin(modifyAnAdminUsername.SelectedText);
            //modifyAnAdminUsername.SelectedItem

            if ( modifyAnAdminUsername.Text != "" )
            {
                
            }

            // whitelist controls for new user
            var modifyCanWhiteListCop = "0";
            var modifyCanWhiteListMed = "0";

            // Restrictions for new user

            if (connection.modifyKickingRestricted == "0")
            {
                modifyRestrictKicking.Checked = true;
            }

            if (modifyRestrictKicking.Checked)
            {
                connection.modifyKickingRestricted = "1";
            }
            if ( connection.modifyKickingRestricted == "0" )
            {
                modifyRestrictKicking.Checked = true;
            }

            if (modifyRestrictBanning.Checked)
            {
                connection.modifyBanningRestricted = "1";
            }

            if (modifyRestrictCompensation.Checked)
            {
                connection.modifyCompensationRestricted = "1";
            }

            if (modifyRestrictWhitelisting.Checked)
            {
                connection.modifyWhiteListingRestricted = "1";
            }

            if (modifyRestrictGarageView.Checked)
            {
                connection.modifyGarageViewRestricted = "1";
            }

            if (modifyRestrictGarageComp.Checked)
            {
                connection.modifyGarageCompRestricted = "1";
            }

            if (modifyMarquee.Checked)
            {
                connection.modifyCanUseMarquee = "1";
            }

            //if (modifySuperAdmin.Checked)
            //{
            //    connection.modify = "1";
            //}

            RefreshComboBoxs();
            ClearModifyTab();
        }

        private void removeAnAdminRemoveBtn_Click(object sender, EventArgs e)
        {
            Connections connections = new Connections();

            if ( removeAnAdminUsername.Text != "" )
            {
                string query = "DELETE FROM admintools_logon WHERE AdminUsername ='" + removeAnAdminUsername.Text + "'";
                connections.RunScript(query);
                RefreshComboBoxs();
            }
            else
            {
                MessageBox.Show( "Please select a user to remove!", "Select a user" );
            }
            
        }
        
        private void RefreshComboBoxs()
        {
            Connections connections = new Connections();
            string query = "SELECT AdminUsername FROM admintools_logon";
            //string query2 = "SELECT AdminName FROM admintools_restrictions"; // Remove this when fixed db

            modifyAnAdminUsername.Items.Clear();
            removeAnAdminUsername.Items.Clear();

            modifyAnAdminUsername.Text = "";
            removeAnAdminUsername.Text = "";

            // Query uses Select AdminUserName from AdminTools_Logon which is different then AdminName column name
            // TODO: Move all of the data from restrictions to Logon
            connections.PopulateAdminFormComboBox(query, modifyAnAdminUsername);
            connections.PopulateAdminFormComboBox(query, removeAnAdminUsername);
        }

        private void startPassowrdHasher_Click(object sender, EventArgs e)
        {
            PasswordHasher hasher = new PasswordHasher();
            hasher.Show();
        }

        private void addAnAdminClearFieldsBtn_Click(object sender, EventArgs e)
        {
            ClearAddAUserTab();
        }

        private void ClearAddAUserTab()
        {
            addAnAdminUserName.Text = "";
            addAnAdminPassword.Text = "";

            foreach (CheckBox c in whiteListGroupBox.Controls)
            {
                c.Checked = false;
            }

            foreach (CheckBox c in restrictionsGroupBox.Controls)
            {
                c.Checked = false;
            }
        }

        private void clearModifyUserFields_Click(object sender, EventArgs e)
        {
            ClearModifyTab();
        }

        private void ClearModifyTab()
        {
            modifyAnAdminUsername.Text = "";

            foreach (CheckBox c in modifyWhiteListGroupBox.Controls)
            {
                c.Checked = false;
            }

            foreach (CheckBox c in modifyRestrictionsGroupBox.Controls)
            {
                c.Checked = false;
            }
        }
    }
}
