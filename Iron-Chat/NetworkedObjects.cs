using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Iron_Chat
{
    [Serializable]
    class NUserJoin
    {
        public byte netID = 1;
        public short userID;
        public string username;

        public byte[] Serialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(BitConverter.GetBytes(netID), 0, 1);
                ms.Write(new byte[4], 0, 4);
                formatter.Serialize(ms, this);
                ms.Position = 1;
                ms.Write(BitConverter.GetBytes(ms.ToArray().Length), 0, 4);
                Console.WriteLine(ms.ToArray().Length);
                return ms.ToArray();
            }
        }

        public void Deserialize(byte[] data)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                Int32 size = BitConverter.ToInt32(data, 1);
                Console.WriteLine(size);
                ms.Write(data, 4, size-5);
                ms.Position = 0;
                NUserJoin user = new NUserJoin();
                user = (NUserJoin)formatter.Deserialize(ms);
                this.userID = user.userID;
                this.username = user.username;
            }
        }
    }

    [Serializable]
    class NUserLeave
    {
        public byte netID = 2;
        public short userID;

        public byte[] Serialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(BitConverter.GetBytes(netID), 0, 1);
                formatter.Serialize(ms, this);
                return ms.ToArray();
            }
        }

        public void Deserialize(byte[] data)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(data, 1, data.Length-1);
                NUserLeave user = (NUserLeave)formatter.Deserialize(ms);
                this.userID = user.userID;
            }
        }
    }

    [Serializable]
    class NMessage
    {
        public byte netID = 3;
        public short userID;
        public string message;

        public byte[] Serialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(BitConverter.GetBytes(netID), 0, 1);
                formatter.Serialize(ms, this);
                return ms.ToArray();
            }
        }

        public void Deserialize(byte[] data)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(data, 1, data.Length-1);
                NMessage msg = (NMessage)formatter.Deserialize(ms);
                this.userID = msg.userID;
                this.message = msg.message;
            }
        }
    }
}
