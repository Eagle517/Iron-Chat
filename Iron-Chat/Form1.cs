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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == SystemColors.GrayText)
            {
                textBox1.ForeColor = SystemColors.WindowText;
                textBox1.Text = "";
            }
        }

        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.ForeColor = SystemColors.GrayText;
                textBox1.Text = "Address";
            }
        }

        private void textBox2_GotFocus(object sender, EventArgs e)
        {
            if (textBox2.ForeColor == SystemColors.GrayText)
            {
                textBox2.ForeColor = SystemColors.WindowText;
                textBox2.Text = "";
            }
        }

        private void textBox2_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.ForeColor = SystemColors.GrayText;
                textBox2.Text = "Port";
            }
        }
    }
}
