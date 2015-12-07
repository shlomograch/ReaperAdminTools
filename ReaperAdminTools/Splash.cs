using System;
using System.Windows.Forms;

namespace ReaperAdminTools
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        public int timeLeft { get; set; }
        private void Splash_Load(object sender, EventArgs e)
        {
            timeLeft = 40;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ( timeLeft > 0 )
            {
                timeLeft = timeLeft - 1;
            }

            else
            {
                timer1.Stop();
                new LoginForm().Show();
                Hide();
            }
        }
    }
}
