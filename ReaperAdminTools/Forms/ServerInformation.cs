using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReaperAdminTools
{
    public partial class ServerInformationForm : Form
    {
        public ServerInformationForm()
        {
            InitializeComponent();
        }

        private void searchForPlaerName_Click(object sender, EventArgs e)
        {
            if ( searchForPlayer.Text.Length > 1 )
            {
                foreach ( ListViewItem item in playerListView.Items)
                {
                    if ( !item.SubItems[1].Text.Contains( searchForPlayer.Text ) ) // Can check case?
                    {
                        playerListView.Items.Remove( item );
                    }
                }
            }
        }
    }
}
