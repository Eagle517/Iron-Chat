using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Iron_Chat
{
    public class MessageReceivedEventArgs : EventArgs
    {
        private readonly string username;
        private readonly string message;

        public MessageReceivedEventArgs(string name, string msg)
        {
            username = name;
            message = msg;
        }

        public string Message
        {
            get { return message; }
        }

        public string Username
        {
            get { return username; }
        }
    }
    public delegate void MessageReceivedEventHandler(object sender, MessageReceivedEventArgs e);

    public class UserJoinEventArgs : EventArgs
    {
        private readonly string username;

        public UserJoinEventArgs(string name)
        {
            username = name;
        }

        public string Username
        {
            get { return username; }
        }
    }
    public delegate void UserJoinEventHandler(object sender, UserJoinEventArgs e);

    public class UserLeaveEventArgs : EventArgs
    {
        private readonly string username;

        public UserLeaveEventArgs(string name)
        {
            username = name;
        }

        public string Username
        {
            get { return username; }
        }
    }
    public delegate void UserLeaveEventHandler(object sender, UserLeaveEventArgs e);

    class User
    {
        public event MessageReceivedEventHandler MessageReceived;
        public event UserJoinEventHandler UserJoin;
        public event UserLeaveEventHandler UserLeave;

        private TcpClient connection;
        private string username;

        public void connect(string ip, int port)
        {
            try
            {
                if (connection.Connected)
                    connection.Close();
                connection = new TcpClient();
                connection.Connect(ip, port);
                receive();
            }
            catch(Exception)
            {

            }
        }

        public void disconnect()
        {
            try
            {
                connection.Close();
            }
            catch(Exception)
            {

            }
        }

        private void receive()
        {
            if (connection.Client.Connected)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    connection.Client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(onReceive), buffer);
                }
                catch (Exception)
                {
                    disconnect();
                }
            }
        }

        private void onReceive(IAsyncResult data)
        {

            receive();
        }
    }
}
