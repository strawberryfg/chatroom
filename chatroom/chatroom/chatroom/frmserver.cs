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
    public partial class frmserver : Form
    {
        private Socket servereceivesocket;
        private IPEndPoint serverinformation;
        private Thread serverthread;
        private Socket[] clientsocket;                
        private int cntclient=0;
        private byte[] information;
        
        public frmserver()
        {
            InitializeComponent();
            clientlisten();
        }
        
        private void clientlisten()
        {
            try
            {
                servereceivesocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                serverinformation = new IPEndPoint(ip, Int32.Parse("20"));
                servereceivesocket.Bind(serverinformation); //server's IP and port number  build tag for new socket
                servereceivesocket.Listen(1000); //maximum hang number  listen outside connection request
                
                clientsocket = new Socket[65535];
                information = new byte[65535];
                cntclient = 0;

                serverthread = new Thread(new ThreadStart(receiveaccept)); //receive coming connection on the socket
                serverthread.Start();
            }
            catch (System.Exception ex)
            {

            }
        }
        
        private string processed(string x)
        {
            for (int i = 0; i < x.Length; i++) if (x[i].Equals('!')) return x.Substring(0, i+1);
            return x;   
        }

        private void receiveaccept()
        {
            while (true)
            {
                clientsocket[cntclient] = servereceivesocket.Accept();            
                clientsocket[cntclient].BeginReceive(information, 0, information.Length, SocketFlags.None, new AsyncCallback(receivecallback), clientsocket[cntclient]);
                this.Invoke((MethodInvoker)delegate
                {
                    lock (this.txtinfo) this.txtinfo.Text += "0 "+clientsocket[cntclient].RemoteEndPoint.ToString() + " 进入系统!\r\n";
                    
                });
                cntclient++;                
            }
        }
        
        private void receivecallback(IAsyncResult ar)
        {
            try
            {
                Socket receivesocket = (Socket)ar.AsyncState;                
                int receiveend = receivesocket.EndReceive(ar);

                for (int i = 0; i <= cntclient; i++)
                {
                    if (clientsocket[i].Connected)
                    {                        
                        clientsocket[i].Send(Encoding.Unicode.GetBytes("2 "+DateTime.Now.ToString()+":\r\n    "+ System.Text.Encoding.Unicode.GetString(information)+"\r\n" ),SocketFlags.None);
                    }
                    receivesocket.BeginReceive(information, 0, information.Length, 0, new AsyncCallback(receivecallback), receivesocket);
                    string s = Encoding.Unicode.GetString(information);
                    if ((s[0].Equals('0') || s[0].Equals('3')) && i==0)
                    {
                        if (txtinfo.Text.Length != 0)
                        {
                            //this.Text = txtinfo.Text.Substring(txtinfo.Text.Length - 8, 9);
                            this.txtinfo.Text += processed(Encoding.Unicode.GetString(information)) + "\r\n";

                            //clientsocket[i].Send(Encoding.Unicode.GetBytes(processed(Encoding.Unicode.GetString(information)) + "\r\n"));
                        }
                    }
                }
                
                
                
            }
            catch(SystemException err)
            {
                return;
            }
        }

        private void frmserver_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmserver_FormClosed(object sender, FormClosedEventArgs e)
        {
            servereceivesocket.Close();//关闭SOCKET
            serverthread.Abort();
            
            
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
