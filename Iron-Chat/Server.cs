using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Iron_Chat
{
    class Server
    {
        TcpListener listener;
        public void open(int port)
        {
            try
            {
                listener = new TcpListener(getLocalIP(), port);
                listener.Start();
                listenForConnections();
                listenForData();
            }
            catch(Exception)
            {

            }
        }

        public void close()
        {
            listener.Stop();
        }

        private void listenForConnections()
        {
            listener.BeginAcceptTcpClient(new AsyncCallback(onConnectAttempt), listener);
        }

        private void onConnectAttempt(IAsyncResult ar)
        {
            TcpClient client = listener.EndAcceptTcpClient(ar);
        }

        private IPAddress getLocalIP()
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                return endPoint.Address.MapToIPv4();
            }
        }
    }
}
