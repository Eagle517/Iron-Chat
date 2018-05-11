namespace Iron_Chat
{
    partial class wJoinHost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPortJoin = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnHost = new System.Windows.Forms.Button();
            this.txtPortHost = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(255, 107);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtPortJoin);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(247, 81);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Join";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtPortJoin
            // 
            this.txtPortJoin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPortJoin.Location = new System.Drawing.Point(156, 23);
            this.txtPortJoin.Name = "txtPortJoin";
            this.txtPortJoin.Size = new System.Drawing.Size(83, 20);
            this.txtPortJoin.TabIndex = 2;
            this.txtPortJoin.Text = "Port";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(90, 49);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtAddress.Location = new System.Drawing.Point(8, 23);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(142, 20);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Text = "Address";
            this.txtAddress.GotFocus += new System.EventHandler(this.textBox1_GotFocus);
            this.txtAddress.LostFocus += new System.EventHandler(this.textBox1_LostFocus);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnHost);
            this.tabPage2.Controls.Add(this.txtPortHost);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(247, 81);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Host";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnHost
            // 
            this.btnHost.Location = new System.Drawing.Point(90, 49);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(75, 23);
            this.btnHost.TabIndex = 3;
            this.btnHost.Text = "Host";
            this.btnHost.UseVisualStyleBackColor = true;
            this.btnHost.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPortHost
            // 
            this.txtPortHost.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPortHost.Location = new System.Drawing.Point(67, 22);
            this.txtPortHost.Name = "txtPortHost";
            this.txtPortHost.Size = new System.Drawing.Size(121, 20);
            this.txtPortHost.TabIndex = 2;
            this.txtPortHost.Text = "Port";
            this.txtPortHost.GotFocus += new System.EventHandler(this.textBox2_GotFocus);
            this.txtPortHost.LostFocus += new System.EventHandler(this.textBox2_LostFocus);
            // 
            // wJoinHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 107);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wJoinHost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iron Chat";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnHost;
        private System.Windows.Forms.TextBox txtPortHost;
        private System.Windows.Forms.TextBox txtPortJoin;
    }
}

