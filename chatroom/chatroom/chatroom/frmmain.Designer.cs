namespace chatroom
{
    partial class frmmain
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
            this.btnshowclient = new System.Windows.Forms.Button();
            this.btnshowserver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnshowclient
            // 
            this.btnshowclient.BackColor = System.Drawing.SystemColors.Window;
            this.btnshowclient.Location = new System.Drawing.Point(40, 111);
            this.btnshowclient.Name = "btnshowclient";
            this.btnshowclient.Size = new System.Drawing.Size(98, 53);
            this.btnshowclient.TabIndex = 0;
            this.btnshowclient.Text = "客户端";
            this.btnshowclient.UseVisualStyleBackColor = false;
            this.btnshowclient.Click += new System.EventHandler(this.btnshowclient_Click);
            // 
            // btnshowserver
            // 
            this.btnshowserver.BackColor = System.Drawing.SystemColors.Window;
            this.btnshowserver.Location = new System.Drawing.Point(40, 27);
            this.btnshowserver.Name = "btnshowserver";
            this.btnshowserver.Size = new System.Drawing.Size(101, 52);
            this.btnshowserver.TabIndex = 1;
            this.btnshowserver.Text = "服务器";
            this.btnshowserver.UseVisualStyleBackColor = false;
            this.btnshowserver.Click += new System.EventHandler(this.btnshowserver_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(178, 197);
            this.Controls.Add(this.btnshowserver);
            this.Controls.Add(this.btnshowclient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "主界面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmmain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnshowclient;
        private System.Windows.Forms.Button btnshowserver;
    }
}