using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            if(Uri.IsWellFormedUriString(url,UriKind.Absolute))
            {
                MessageBox.Show("Valid url");
                WebClient client = new WebClient();
                string[] fileparts = url.Split('/');
                string filename = fileparts.Last();
                client.DownloadFile(url, $"C:\\Users\\Alchemy.DESKTOP-V8A10HM\\Documents\\{filename}");


            }
            else
            {
                MessageBox.Show("Invalid url");
            }
        }
    }
}
