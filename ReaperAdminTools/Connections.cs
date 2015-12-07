using System;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

using ReaperAdminTools.Properties;

namespace ReaperAdminTools
{
    class Connections
    {
        MySqlConnection mySqlConn = new MySqlConnection(Resources.connectionInfo);
        MySqlCommand command;
        MySqlDataReader reader;

        public void LoginConnection(string query)
        {
            try
            {
                mySqlConn.Open();
                command = new MySqlCommand(query, mySqlConn);
                reader = command.ExecuteReader();

                int count = 0;

                while (reader.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    MessageBox.Show("Success!");
                }
                else
                {
                    //MessageBox.Show("Failure! :(");
                }
                mySqlConn.Close();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            finally
            {
                mySqlConn.Dispose();
            }
        }

        // SQL Command script with no Reader.
        public void RunScript(string query)
        {
            try
            {
                mySqlConn.Open();
                command = new MySqlCommand(query, mySqlConn);
                reader = command.ExecuteReader();

                mySqlConn.Close();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            finally
            {
                mySqlConn.Dispose();
            }
        }
        
        public void PopulateAdminFormComboBox( string query, ComboBox control )
        {
            try
            {
                mySqlConn.Open();
                command = new MySqlCommand( query, mySqlConn );
                reader = command.ExecuteReader();

                while ( reader.Read() )
                {
                    control.Items.Add( reader["AdminUsername"] );
                }

                mySqlConn.Close();
            }

            catch ( Exception exception )
            {
                MessageBox.Show( exception.Message );
            }

            finally
            {
                mySqlConn.Dispose();
            }
        }

        public string modifyKickingRestricted { get; set; }
        public string modifyBanningRestricted { get; set; }
        public string modifyCompensationRestricted { get; set; }
        public string modifyWhiteListingRestricted { get; set; }
        public string modifyGarageViewRestricted { get; set; }
        public string modifyGarageCompRestricted { get; set; }
        public string modifyCanUseMarquee { get; set; }
        //public string modifyisSuperAdmin { get; set; }

        public void PopulateSuperAdminModifyAdmin( string adminName )
        {
            // TODO: Change "TestSubject" back to adminName parameter
            string query = "SELECT * FROM admintools_restrictions WHERE AdminName='" + "TestSubject" + "'";
            try
            {
                mySqlConn.Open();
                command = new MySqlCommand( query, mySqlConn );
                reader = command.ExecuteReader();

                while ( reader.Read() )
                {
                    modifyKickingRestricted = reader.GetString( "AdminRestrictKicking" );
                    modifyBanningRestricted = reader.GetString( "AdminRestrictBanning" );
                    modifyCompensationRestricted = reader.GetString( "AdminRectrictCompensation" );
                    modifyWhiteListingRestricted = reader.GetString( "AdminRestrictWhiteListing" );
                    modifyGarageViewRestricted = reader.GetString( "AdminRestrictGarageView" );
                    modifyGarageCompRestricted = reader.GetString( "AdminRestrictGarageComp" );
                    modifyCanUseMarquee = reader.GetString( "AdminRestrictMarquee" );
                    //modifyisSuperAdmin = reader.GetString( "AdminIsSuperAdmin" );
                }

                mySqlConn.Close();
            }

            catch ( Exception exception )
            {
                MessageBox.Show( exception.Message );
            }

            finally
            {
                mySqlConn.Dispose();
            }
        }
    }
}
