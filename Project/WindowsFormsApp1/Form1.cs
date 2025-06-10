using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Socket server;
        List<Socket> Clients;
        string[] clientsList = { "client 1", "client 2", "client 3", "client 4", "client 5" };
        int numOfClientForms = 0;
        int numOfClients = 0;
        public Form1()
        {
            InitializeComponent();
            Clients = new List<Socket>();
        }
        private void UpdateGui(bool isConnected)
        {
            btnstartserver.Enabled = !isConnected;
            btnsend.Enabled = isConnected;
            lblstatus.Text = isConnected ? "Connected" : "Disconnected";
            lblstatus.ForeColor = isConnected ? Color.Green : Color.Red;
        }

        private void btnstartserver_Click(object sender, EventArgs e)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int portnum = int.Parse(txtserverport.Text);
            server.Bind(new IPEndPoint(IPAddress.Any, portnum));
            server.Listen(5);
            UpdateGui(true);
            Writelog("Server Started..");
            server.BeginAccept(new AsyncCallback(OnClientConnect), null);
        }
        private void OnClientConnect(IAsyncResult ar)
        {
            Socket client = server.EndAccept(ar);
            Clients.Add(client);
            ReadytoSend(client);
            server.BeginAccept(new AsyncCallback(OnClientConnect), null);
        }
        private void ReadytoSend(Socket client)
        {
            socketPacket packet = new socketPacket(client);
            client.BeginReceive(packet.buffer, 0, packet.buffer.Length, SocketFlags.None, new AsyncCallback(OnRecieve), packet);
        }
        private void OnRecieve(IAsyncResult ar)
        {
            socketPacket packet = (socketPacket)ar.AsyncState;
            packet.client.EndReceive(ar);
            string msg = Encoding.Unicode.GetString(packet.buffer);
            Writelog(msg);
            ReadytoSend(packet.client);

        }
        private void Writelog(string msg)
        {
            MethodInvoker inv = new MethodInvoker(delegate { txtlog.AppendText(msg + Environment.NewLine); });
            this.BeginInvoke(inv);
        }

        private void btnnewclient_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Text = updateFormname();
            f.Show();
            addClientToList();
        }
        // Give names to Clients form.
        private string updateFormname()
        {
            string formName = clientsList[numOfClients];
            numOfClientForms = numOfClientForms + 1;
            return formName;
        }
        // Add client to CheckedListBox.
        private void addClientToList()
        {
            Client_List.Items.Add(clientsList[numOfClients]);
            numOfClients = numOfClients + 1;
        }
        private void btnsend_Click(object sender, EventArgs e)
        {
            string msg = txtSendtoAllClients.Text;
            byte[] buffer = Encoding.Unicode.GetBytes(msg);
            foreach (Socket client in Clients)
            {
                if (client.Connected)
                {
                    client.Send(buffer);
                }
            }
        }
        // Send to selected Clients.
        private void button2_Click(object sender, EventArgs e)
        {
            string msg = txtSendtoAllClients.Text;
            byte[] buffer = Encoding.Unicode.GetBytes(msg);

            for (int i = 0; i < Client_List.CheckedIndices.Count; i++)
            {
                Clients[Client_List.CheckedIndices[i]].Send(buffer);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtlog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}