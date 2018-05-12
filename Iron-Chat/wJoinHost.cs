using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iron_Chat
{
    public partial class wJoinHost : Form
    {
        public wJoinHost()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            if (txtAddress.ForeColor == SystemColors.GrayText)
            {
                txtAddress.ForeColor = SystemColors.WindowText;
                txtAddress.Text = "";
            }
        }

        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddress.Text))
            {
                txtAddress.ForeColor = SystemColors.GrayText;
                txtAddress.Text = "Address";
            }
        }

        private void textBox2_GotFocus(object sender, EventArgs e)
        {
            if (txtPortHost.ForeColor == SystemColors.GrayText)
            {
                txtPortHost.ForeColor = SystemColors.WindowText;
                txtPortHost.Text = "";
            }
        }

        private void textBox2_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPortHost.Text))
            {
                txtPortHost.ForeColor = SystemColors.GrayText;
                txtPortHost.Text = "Port";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int port = int.Parse(txtPortHost.Text);
                if (port >= 0 && port <= 65535)
                {
                    this.Hide();
                    wChat chatWindow = new wChat();
                    chatWindow.openServer(port);
                    chatWindow.ShowDialog();
                    this.Show();
                }
            }
            catch(Exception)
            {

            }

            //After the server is being setup bring up the main chat window
            wChat f = new wChat();
            f.MdiParent = Application.OpenForms["wMainWindow"];
            f.Show();
            this.Close();
        }
    }
}
