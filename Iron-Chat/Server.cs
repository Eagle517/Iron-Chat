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
            close();
        }

        public void open(int port)
        {
            try
            {
                listener = new TcpListener(getLocalIP(), port);
                listener.Start();
                listenForConnections();
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
            byte[] ack = { 25 };
            TcpClient tcp = listener.EndAcceptTcpClient(ar);
            tcp.Client.Send(ack);

            State state = new State();
            state.tcp = tcp;
            tcp.Client.BeginReceive(state.buffer, 0, state.buffer.Length, SocketFlags.None, new AsyncCallback(onUserAck), state);
        }

        private void onUserAck(IAsyncResult ar)
        {
            State state = (State)ar.AsyncState;
            TcpClient tcp = state.tcp;
            byte[] buffer = state.buffer;

            if(buffer[0] == (byte)32)
            {
                string name = System.Text.Encoding.UTF8.GetString(buffer, 1, buffer.Length);
                if(!String.IsNullOrWhiteSpace(name))
                {
                    User user = new User(tcp);
                    user.Username = name;
                    user.UserID = userID;
                    users.Add(user);

                    NUserJoin notification = new NUserJoin();
                    notification.userID = userID;
                    notification.username = name;
                    userID++;

                    byte[] nbuf = notification.Serialize();
                    listener.Server.Send(nbuf, 0, nbuf.Length, SocketFlags.Broadcast);

                    UserState uState = new UserState();
                    uState.user = user;
                    user.Connection.Client.BeginReceive(uState.buffer, 0, uState.buffer.Length, SocketFlags.None, new AsyncCallback(onUserData), uState);
                }
            }
        }

        private void onUserData(IAsyncResult ar)
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
