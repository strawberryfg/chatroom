namespace chatroom
{
    partial class frmclient
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
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.txtsend = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.txtnickname = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtinfo
            // 
            this.txtinfo.BackColor = System.Drawing.Color.White;
            this.txtinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtinfo.Location = new System.Drawing.Point(42, 37);
            this.txtinfo.Multiline = true;
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.ReadOnly = true;
            this.txtinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtinfo.Size = new System.Drawing.Size(392, 414);
            this.txtinfo.TabIndex = 0;
            // 
            // txtsend
            // 
            this.txtsend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsend.Location = new System.Drawing.Point(42, 498);
            this.txtsend.Multiline = true;
            this.txtsend.Name = "txtsend";
            this.txtsend.Size = new System.Drawing.Size(392, 114);
            this.txtsend.TabIndex = 1;
            // 
            // btnsend
            // 
            this.btnsend.BackColor = System.Drawing.SystemColors.Window;
            this.btnsend.Location = new System.Drawing.Point(455, 561);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(73, 51);
            this.btnsend.TabIndex = 2;
            this.btnsend.Text = "发送";
            this.btnsend.UseVisualStyleBackColor = false;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // txtnickname
            // 
            this.txtnickname.Location = new System.Drawing.Point(455, 63);
            this.txtnickname.Name = "txtnickname";
            this.txtnickname.Size = new System.Drawing.Size(79, 21);
            this.txtnickname.TabIndex = 3;
            this.txtnickname.TextChanged += new System.EventHandler(this.txtnickname_TextChanged);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(453, 39);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(41, 12);
            this.lblusername.TabIndex = 4;
            this.lblusername.Text = "用户名";
            // 
            // frmclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 667);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtnickname);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txtsend);
            this.Controls.Add(this.txtinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(200, 0);
            this.MaximizeBox = false;
            this.Name = "frmclient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "客户端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmclient_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmclient_FormClosed);
            this.Load += new System.EventHandler(this.frmclient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.TextBox txtsend;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.TextBox txtnickname;
        private System.Windows.Forms.Label lblusername;
    }
}