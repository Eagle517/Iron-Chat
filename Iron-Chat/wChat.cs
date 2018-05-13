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
    public partial class wChat : Form
    {
        Server server;
        User myself;

        public wChat()
        {
            InitializeComponent();
        }

        public void openServer(int port)
        {
            server = new Server();
            server.Open(port);

            myself = new User();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }
    }
}
