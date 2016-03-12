using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatroom
{
    
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
            this.btnshowclient.Enabled = false;
        }
        public frmserver froot;
        private void btnshowclient_Click(object sender, EventArgs e)
        {            
            frmclient f = new frmclient();
            f.from = froot;
            f.Show();
        }

        private void btnshowserver_Click(object sender, EventArgs e)
        {
            frmserver f = new frmserver();
            froot = f;
            f.Show();
            btnshowserver.Enabled = false;
            btnshowclient.Enabled = true;
        }

        private void frmmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
