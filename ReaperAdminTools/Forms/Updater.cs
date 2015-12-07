using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ReaperAdminTools
{
    public partial class Updater : Form
    {
        private TcpClient client { get; set; }

        public Updater()
        {
            InitializeComponent();
        }

        private void Updater_Load(object sender, EventArgs e)
        {
            // do something when we laod..
            timer1.Start();
        }

        private void CheckForUpdates()
        {
            if (newProgressBar1.Value == 100)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("Distro Link goes here");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader streamReader = new StreamReader(response.GetResponseStream());

                var newestVersion = streamReader.ReadToEnd();
                var currentVersion = Application.ProductVersion;

                if (newestVersion.Contains(currentVersion))
                {
                    MessageBox.Show("You're up to date scrub lord Jr.");
                    // Add some actions
                }
                else
                {
                    MessageBox.Show("Stop crying to your mom and go get the update scrub");
                    webBrowser1.Navigate("Distro link goes here");
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //newProgressBar1.Increment(1);
            //if (newProgressBar1.Value == 100)
            //{
            //    timer1.Stop();
            //    if (newProgressBar1.Value == 100)
            //    {
            //        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("Distro Link goes here");
            //        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //        StreamReader streamReader = new StreamReader(response.GetResponseStream());

            //        var newestVersion = streamReader.ReadToEnd();
            //        var currentVersion = Application.ProductVersion;

            //        if (newestVersion.Contains(currentVersion))
            //        {
            //            MessageBox.Show("You're up to date scrub lord Jr.");
            //            // Add some actions
            //        }
            //        else
            //        {
            //            MessageBox.Show("Stop crying to your mom and go get the update scrub");
            //            webBrowser1.Navigate("Distro link goes here");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Scrub downloading update");
            //        webBrowser1.Navigate("Distro link");
            //    }

            //}
        }
    }
}
