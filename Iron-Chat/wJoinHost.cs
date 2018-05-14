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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (tabJoinHost.SelectedTab.Text == "Host")
            {
                try
                {
                    int port = int.Parse(txtPortHost.Text);
                    if (port >= 0 && port <= 65535)
                    {
                        //this.Hide();
                        //wChat chatWindow = new wChat();
                        //chatWindow.openServer(port);
                        //chatWindow.ShowDialog();
                        //this.Show();

                        wChat f = new wChat
                        {
                            MdiParent = Application.OpenForms["wMainWindow"]
                        };
                        f.Show();
                        f.openServer(port);
                        this.Close();
                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {

            }
        }

        private void tabJoinHost_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAccept.Text = tabJoinHost.SelectedTab.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
