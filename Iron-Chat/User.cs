using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

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
        private short userID;

        public string Username
        {
            get { return username; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    username = value;
            }
        }

        public short UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public TcpClient Connection
        {
            get { return connection; }
        }

        public User() { }
        public User(TcpClient conn)
        {
            connection = conn;
        }

        public void Log(string msg)
        {
            Console.WriteLine("User   | {0}", msg);
        }

        public void Connect(string ip, int port)
        {
            try
            {
                Log("Attempting to connect to " + ip + ":" + port.ToString());
                if (connection != null && connection.Connected)
                    connection.Close();
                connection = new TcpClient();
                connection.BeginConnect(ip, port, new AsyncCallback(OnConnected), connection);
            }
            catch(Exception)
            {

            }
        }

        private void OnConnected(IAsyncResult ar)
        {
            try
            {
                connection.EndConnect(ar);
                Log("Connected to server");
                Receive();
            }
            catch(Exception)
            {

            }
        }

        public void Disconnect()
        {
            try
            {
                connection.Close();
            }
            catch(Exception)
            {

            }
        }

        private void Receive()
        {
            if (connection.Client.Connected)
            {
                try
                {
                    Log("Receiving from server");
                    byte[] buffer = new byte[2048];
                    connection.Client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(OnReceive), buffer);
                }
                catch (Exception)
                {
                    Disconnect();
                }
            }
        }

        private void OnReceive(IAsyncResult ar)
        {
            byte[] buffer = (byte[])ar.AsyncState;
            Log("BUFFER FLAG " + buffer[0].ToString());
            switch (buffer[0])
            {
                case 25:
                    Log("Received ack from server");
                    byte[] ack = { 32 };
                    using (MemoryStream ms = new MemoryStream())
                    {
                        ms.Write(ack, 0, 1);
                        string name = "Testing";
                        foreach(char c in name)
                        {
                            ms.WriteByte((byte)c);
                        }
                        Send(ms.ToArray());
                    }
                    break;

                case 1:
                    Log("Join notification received");
                    Log(buffer.Length.ToString());
                    NUserJoin notification = new NUserJoin();
                    notification.Deserialize(buffer);
                    Log("Username: " + notification.username);
                    Log("User ID: " + notification.userID);
                    break;

                default:
                    break;
            }

            connection.Client.EndReceive(ar);
            Receive();
        }

        public void Send(byte[] buffer)
        {
            Log("Sending to remote connection");
            connection.Client.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(OnSend), connection);
        }

        private void OnSend(IAsyncResult ar)
        {
            Log("Finished sending to remote connection");
            connection.Client.EndSend(ar);
        }
    }
}
