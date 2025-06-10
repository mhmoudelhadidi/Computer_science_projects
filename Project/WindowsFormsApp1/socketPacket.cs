using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
namespace WindowsFormsApp1
{
    class socketPacket
    {
        public Socket client { get; set; }
        public byte [] buffer { get; set; }
        public socketPacket(Socket client)
        {
            this.client = client;
            this.buffer = new byte[1024];
        }
    }
}
