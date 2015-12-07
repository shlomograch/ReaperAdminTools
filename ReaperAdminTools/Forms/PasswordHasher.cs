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
    public partial class PasswordHasher : Form
    {
        public PasswordHasher()
        {
            InitializeComponent();
        }

        private void stringToHash_TextChanged( object sender, EventArgs e )
        {
            Encryption encryption = new Encryption();
            hashedString.Text = encryption.GetSha1Hash( stringToHash.Text );
        }
    }
}
