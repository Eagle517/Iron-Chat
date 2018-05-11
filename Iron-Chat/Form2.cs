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
    public partial class Form2 : Form
    {
        Server server;
        User user;

        public Form2()
        {
            InitializeComponent();
        }

        public void openServer(int port)
        {
            server = new Server();
            server.open(port);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
