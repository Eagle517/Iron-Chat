using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iron_Chat
{
    class FETextBox : TextBox
    {
        private string _placeholder;
        public string Placeholder
        {
            get { return _placeholder; }
            set
            {
                _placeholder = value;
                this.Text = value;
                this.ForeColor = SystemColors.GrayText;
            }
        }

        public FETextBox()
        {
            this.GotFocus += new System.EventHandler(this.OnGotFocus);
            this.LostFocus += new System.EventHandler(this.OnLostFocus);
        }

        private void OnGotFocus(object sender, EventArgs e)
        {
            FETextBox box = (FETextBox)sender;
            if (box.ForeColor == SystemColors.GrayText)
            {
                box.ForeColor = SystemColors.WindowText;
                box.Text = "";
            }
        }

        private void OnLostFocus(object sender, EventArgs e)
        {
            FETextBox box = (FETextBox)sender;
            if (String.IsNullOrWhiteSpace(box.Text))
            {
                box.ForeColor = SystemColors.GrayText;
                box.Text = box.Placeholder;
            }
        }
    }
}
