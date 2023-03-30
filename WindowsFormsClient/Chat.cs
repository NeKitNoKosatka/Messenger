//using ConsoleMessenger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Messenger;
using WindowsFormsClient.Properties;

namespace WindowsFormsClient
{
    public partial class Chat : Form
    {
        private static int MessageID = 0;
        private static string UserName;
        private static MessengerClientAPI API = new MessengerClientAPI();

        

        public Chat()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            //UserName = NameTB.Text;
            //string Message = MessageTB.Text;
            //if ((UserName.Length > 1) && (UserName.Length > 1))
            //{
            //    //Messenger.Message msg = new Messenger.Message(UserName, Message, DateTime.Now);
            //    //API.SendMessage(msg);
            //}
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            //var getMessage = new Func<Task>(async () =>
            //{
            //    //Messenger.Message msg = await API.GetMessageHTTPAsync(MessageID);
            //    //while (msg != null)
            //    {
            //        //MessagesLB.Items.Add(msg);
            //        MessageID++;
            //       // msg = await API.GetMessageHTTPAsync(MessageID);
            //    }
            //});
            //getMessage.Invoke();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Connection.Close();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string query = "SELECT login FROM users WHERE id = 1";

        //    OleDbCommand command = new OleDbCommand(query, Connection);

        //    MessagesLB.Items.Add(command.ExecuteScalar().ToString());

        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    MessageID = 0;
        //}


    }
}