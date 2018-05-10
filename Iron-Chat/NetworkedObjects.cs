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
                formatter.Serialize(ms, this);
                return ms.ToArray();
            }
        }

        public void Deserialize(byte[] data)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(data, 0, data.Length);
                NUserJoin user = (NUserJoin)formatter.Deserialize(ms);
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
                formatter.Serialize(ms, this);
                return ms.ToArray();
            }
        }

        public void Deserialize(byte[] data)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(data, 0, data.Length);
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
                formatter.Serialize(ms, this);
                return ms.ToArray();
            }
        }

        public void Deserialize(byte[] data)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(data, 0, data.Length);
                NMessage msg = (NMessage)formatter.Deserialize(ms);
                this.userID = msg.userID;
                this.message = msg.message;
            }
        }
    }
}
