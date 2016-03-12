namespace chatroom
{
    partial class frmserver
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
            this.txtlogin = new System.Windows.Forms.Label();
            this.lstcurrent = new System.Windows.Forms.ListView();
            this.chd1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chd2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblcurrent = new System.Windows.Forms.Label();
            this.lblfwq = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblport = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtinfo
            // 
            this.txtinfo.BackColor = System.Drawing.Color.White;
            this.txtinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtinfo.Location = new System.Drawing.Point(21, 64);
            this.txtinfo.Multiline = true;
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.ReadOnly = true;
            this.txtinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtinfo.Size = new System.Drawing.Size(293, 460);
            this.txtinfo.TabIndex = 0;
            // 
            // txtlogin
            // 
            this.txtlogin.AutoSize = true;
            this.txtlogin.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtlogin.Location = new System.Drawing.Point(17, 25);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(85, 19);
            this.txtlogin.TabIndex = 1;
            this.txtlogin.Text = "登陆信息";
            // 
            // lstcurrent
            // 
            this.lstcurrent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chd1,
            this.chd2});
            this.lstcurrent.Location = new System.Drawing.Point(330, 64);
            this.lstcurrent.Name = "lstcurrent";
            this.lstcurrent.Size = new System.Drawing.Size(227, 289);
            this.lstcurrent.TabIndex = 8;
            this.lstcurrent.UseCompatibleStateImageBehavior = false;
            this.lstcurrent.View = System.Windows.Forms.View.Details;
            // 
            // chd1
            // 
            this.chd1.Text = "IP:port";
            this.chd1.Width = 130;
            // 
            // chd2
            // 
            this.chd2.Text = "用户名";
            this.chd2.Width = 110;
            // 
            // lblcurrent
            // 
            this.lblcurrent.AutoSize = true;
            this.lblcurrent.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblcurrent.Location = new System.Drawing.Point(326, 25);
            this.lblcurrent.Name = "lblcurrent";
            this.lblcurrent.Size = new System.Drawing.Size(136, 21);
            this.lblcurrent.TabIndex = 7;
            this.lblcurrent.Text = "当前在线用户";
            // 
            // lblfwq
            // 
            this.lblfwq.AutoSize = true;
            this.lblfwq.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblfwq.Location = new System.Drawing.Point(326, 376);
            this.lblfwq.Name = "lblfwq";
            this.lblfwq.Size = new System.Drawing.Size(89, 20);
            this.lblfwq.TabIndex = 9;
            this.lblfwq.Text = "服务器IP";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(421, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(110, 32);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "127.0.0.1";
            // 
            // lblport
            // 
            this.lblport.AutoSize = true;
            this.lblport.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblport.Location = new System.Drawing.Point(326, 414);
            this.lblport.Name = "lblport";
            this.lblport.Size = new System.Drawing.Size(49, 20);
            this.lblport.TabIndex = 9;
            this.lblport.Text = "端口";
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(421, 410);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(110, 32);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "20";
            // 
            // frmserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 566);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblport);
            this.Controls.Add(this.lblfwq);
            this.Controls.Add(this.lstcurrent);
            this.Controls.Add(this.lblcurrent);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtinfo);
            this.Location = new System.Drawing.Point(780, 0);
            this.MaximizeBox = false;
            this.Name = "frmserver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "服务器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmserver_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmserver_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtlogin;
        public System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.ColumnHeader chd1;
        private System.Windows.Forms.ColumnHeader chd2;
        private System.Windows.Forms.Label lblcurrent;
        public System.Windows.Forms.ListView lstcurrent;
        private System.Windows.Forms.Label lblfwq;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblport;
        private System.Windows.Forms.TextBox textBox2;
    }
}