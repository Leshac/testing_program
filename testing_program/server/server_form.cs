using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Xml;

namespace testing_program
{
    public partial class server_form : Form
    {
        static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public server_form()
        {
            InitializeComponent();
        }

        private void btn_start_server_Click(object sender, EventArgs e)
        {
            socket.Bind(new IPEndPoint(IPAddress.Any, 904));
            socket.Listen(5);
            Socket client = socket.Accept();
            byte[] buffer = new byte[1024];
            client.Receive(buffer);
            string result = Encoding.UTF8.GetString(buffer);
            
        }
    }
}
