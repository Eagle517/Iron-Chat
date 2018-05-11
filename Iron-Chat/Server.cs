using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Iron_Chat
{
    class State
    {
        public TcpClient tcp;
        public byte[] buffer = new byte[1024];
    }

    class UserState
    {
        public User user;
        public byte[] buffer = new byte[1024];
    }

    class Server
    {
        TcpListener listener;
        List<User> users;
        short userID = 0;

        ~Server()
        {
            Close();
        }

        public void Open(int port)
        {
            try
            {
                listener = new TcpListener(GetLocalIP(), port);
                listener.Start();
                ListenForConnections();
            }
            catch(Exception)
            {

            }
        }

        public void Close()
        {
            listener.Stop();
        }

        private void ListenForConnections()
        {
            listener.BeginAcceptTcpClient(new AsyncCallback(OnConnectAttempt), listener);
        }

        private void OnConnectAttempt(IAsyncResult ar)
        {
            byte[] ack = { 25 };
            TcpClient tcp = listener.EndAcceptTcpClient(ar);
            tcp.Client.Send(ack);

            State state = new State
            {
                tcp = tcp
            };
            tcp.Client.BeginReceive(state.buffer, 0, state.buffer.Length, SocketFlags.None, new AsyncCallback(OnUserAck), state);
        }

        private void OnUserAck(IAsyncResult ar)
        {
            State state = (State)ar.AsyncState;
            TcpClient tcp = state.tcp;
            byte[] buffer = state.buffer;

            if(buffer[0] == (byte)32)
            {
                string name = System.Text.Encoding.UTF8.GetString(buffer, 1, buffer.Length);
                if(!String.IsNullOrWhiteSpace(name))
                {
                    User user = new User(tcp)
                    {
                        Username = name,
                        UserID = userID
                    };
                    users.Add(user);

                    NUserJoin notification = new NUserJoin
                    {
                        userID = userID,
                        username = name
                    };
                    userID++;

                    byte[] nbuf = notification.Serialize();
                    listener.Server.Send(nbuf, 0, nbuf.Length, SocketFlags.Broadcast);

                    UserState uState = new UserState
                    {
                        user = user
                    };
                    user.Connection.Client.BeginReceive(uState.buffer, 0, uState.buffer.Length, SocketFlags.None, new AsyncCallback(OnUserData), uState);
                }
            }
        }

        private void OnUserData(IAsyncResult ar)
        {
            UserState uState = (UserState)ar.AsyncState;
            User user = uState.user;
            byte[] buffer = uState.buffer;

            switch (buffer[0])
            {
                case 1:
                    break;
                default:
                    break;
            }
        }

        private IPAddress GetLocalIP()
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
