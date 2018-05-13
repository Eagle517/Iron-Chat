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
            this.tabJoinHost = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPortJoin = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtPortHost = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabJoinHost.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabJoinHost
            // 
            this.tabJoinHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabJoinHost.Controls.Add(this.tabPage1);
            this.tabJoinHost.Controls.Add(this.tabPage2);
            this.tabJoinHost.Location = new System.Drawing.Point(0, 0);
            this.tabJoinHost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabJoinHost.Name = "tabJoinHost";
            this.tabJoinHost.SelectedIndex = 0;
            this.tabJoinHost.Size = new System.Drawing.Size(382, 92);
            this.tabJoinHost.TabIndex = 0;
            this.tabJoinHost.SelectedIndexChanged += new System.EventHandler(this.tabJoinHost_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtPortJoin);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(374, 63);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Join";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtPortJoin
            // 
            this.txtPortJoin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPortJoin.Location = new System.Drawing.Point(256, 6);
            this.txtPortJoin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPortJoin.Name = "txtPortJoin";
            this.txtPortJoin.Size = new System.Drawing.Size(110, 22);
            this.txtPortJoin.TabIndex = 2;
            this.txtPortJoin.Text = "Port";
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtAddress.Location = new System.Drawing.Point(9, 6);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(239, 22);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Text = "Address";
            this.txtAddress.GotFocus += new System.EventHandler(this.textBox1_GotFocus);
            this.txtAddress.LostFocus += new System.EventHandler(this.textBox1_LostFocus);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.txtPortHost);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(374, 63);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Host";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPortHost
            // 
            this.txtPortHost.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPortHost.Location = new System.Drawing.Point(9, 34);
            this.txtPortHost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPortHost.Name = "txtPortHost";
            this.txtPortHost.Size = new System.Drawing.Size(120, 22);
            this.txtPortHost.TabIndex = 2;
            this.txtPortHost.Text = "Port";
            this.txtPortHost.GotFocus += new System.EventHandler(this.textBox2_GotFocus);
            this.txtPortHost.LostFocus += new System.EventHandler(this.textBox2_LostFocus);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(8, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Server Name";
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccept.Location = new System.Drawing.Point(257, 94);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(112, 27);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Join";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(13, 94);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 27);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // wJoinHost
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(382, 129);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabJoinHost);
            this.Controls.Add(this.btnAccept);
            this.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wJoinHost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iron Chat";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tabJoinHost.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabJoinHost;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPortHost;
        private System.Windows.Forms.TextBox txtPortJoin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnClose;
    }
}

