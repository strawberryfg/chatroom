using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace chatroom
{
    public partial class frmclient : Form
    {
        private Socket clientsocket;
        private IPEndPoint serverinformation;               
        private Byte[] buffer;        
        private Byte[] send;        
        private bool exitornot=false;
        private bool first=true;
        public frmserver from;
        public frmclient()
        {
            InitializeComponent();

            buffer = null;
            connectserver();                              
        }
        
        private void connectserver()
        {
            try
            {
                clientsocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                buffer = new byte[65535];
                send = new byte[65535];
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                serverinformation = new IPEndPoint(ip, Int32.Parse("20"));
                clientsocket.Connect(serverinformation);                                
                //clientsocket.Send(Encoding.Unicode.GetBytes("3 " + clientsocket.LocalEndPoint+  "\r\n"));
                clientsocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(receivecallback), null);
                this.txtinfo.Text +=clientsocket.LocalEndPoint+ " 登录服务器 "+clientsocket.RemoteEndPoint+" 成功" + "\r\n";
                this.Text += clientsocket.LocalEndPoint;
            }
            catch (System.Exception ex)
            {

            }
        }

        private void receivecallback(IAsyncResult ar)
        {
            
            try
            {
                int receiveend = clientsocket.EndReceive(ar);
                this.Invoke((MethodInvoker)delegate
                {
                    lock (this.txtinfo)
                    {
                        //if (first == true) { first = false; return; }
                        this.txtinfo.Text += (System.Text.Encoding.Unicode.GetString(buffer)).Substring(2) + "\r\n";
                    }
                });

                clientsocket.BeginReceive(buffer, 0, buffer.Length, 0, new AsyncCallback(receivecallback), null);
            }
            catch(System.Exception err)
            {
                return;
            }
            
        }
      
        private void btnsend_Click(object sender, EventArgs e)
        {
            if (exitornot == true) return;
            send = Encoding.Unicode.GetBytes(/*"1 "+clientsocket.LocalEndPoint+" "+ */txtnickname.Text + "说：\r\n        " + this.txtsend.Text + "\r\n\0");
            if (clientsocket.Connected)
            {
                clientsocket.Send(send);
            }
        }

        private void frmclient_FormClosed(object sender, FormClosedEventArgs e)
        {

            
        }

        private void frmclient_FormClosing(object sender, FormClosingEventArgs e)
        {
      
           btnexit_Click(sender,e);
                           
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < from.lstcurrent.Items.Count; i++)
            {
                ListViewItem lvi = from.lstcurrent.Items[i];
                if (lvi.Text == clientsocket.LocalEndPoint.ToString())
                {
                    from.lstcurrent.Items.RemoveAt(i);
                    break;
                }
            }
            if (clientsocket.Connected)
            {
                clientsocket.Send(Encoding.Unicode.GetBytes("3 "+clientsocket.LocalEndPoint +" ---- "+txtnickname.Text+ " 离开系统!\r\n"));                
                clientsocket.Shutdown(SocketShutdown.Both);                
                clientsocket.Disconnect(false);
            }            
            clientsocket.Close();
            exitornot = true;
        }

        private void frmclient_Load(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = clientsocket.LocalEndPoint.ToString();
            lvi.SubItems.Add(this.txtnickname.Text);
            from.lstcurrent.Items.Add(lvi);
        }

        private void txtnickname_TextChanged(object sender, EventArgs e)
        {
            for (int i=0;i<from.lstcurrent.Items.Count;i++)
            {
                ListViewItem lvi = from.lstcurrent.Items[i];
                if (lvi.Text == clientsocket.LocalEndPoint.ToString()) from.lstcurrent.Items[i].SubItems[1].Text = txtnickname.Text;
            }
        }
    }
}
