﻿using System;
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
    public partial class wMainWindow : Form
    {
        public wMainWindow()
        {
            InitializeComponent();

            wJoinHost f = new wJoinHost
            {
                MdiParent = this
            };
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wMainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
