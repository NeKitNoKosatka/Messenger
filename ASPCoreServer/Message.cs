using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger
{
    [Serializable]
    public class Message
    {
        public string UserName { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeStamp { get; set; }
        public int UserID { get; set; }
        public int ReceiverID { get; set; }
        public int ChatID { get; set; }

        public Message()
        {
            UserName = "System";
            MessageText = "Server is running";
            TimeStamp = DateTime.Now;
            UserID = 0;
            ReceiverID = 1;
            ChatID = 0;
        }

        public Message(string userName, string messageText, DateTime timeStamp, int userID, int receiverID, int chatID)
        {
            UserName = userName;
            MessageText = messageText;
            TimeStamp = timeStamp;
            UserID = userID;
            ReceiverID = receiverID;
            ChatID = chatID;
        }

        public override string ToString()
        {
            string output = String.Format("@{3}\\{0} <{2}>: {1}, {4}, chatid={5}", UserName, MessageText, TimeStamp, UserID, ReceiverID, ChatID);
            return output;
        }
    }
}
