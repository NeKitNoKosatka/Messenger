using Messenger;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class MainForm : Form
    {   
        
        private static int MessageID = 0;

        //private static int MessageID_get = 0;
        private static string userName;//AuthorizationForm.UserName;
        private static MessengerClientAPI API = new MessengerClientAPI();
        private string contact;
        private int ID;
        private int contactID;
        private int chatID;
        //private AuthorizationForm authForm;

        public MainForm()        //AuthorizationForm f)
        {
            InitializeComponent();
            //authForm = f;
            
        }

        private void closing_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closing_button_MouseEnter(object sender, EventArgs e)
        {
            closing_button.ForeColor = Color.Red;
        }

        private void closing_button_MouseLeave(object sender, EventArgs e)
        {
            closing_button.ForeColor = Color.Black;
        }


        Point mousePoint;
        
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        private void MainForm_MouseDown_1(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        private void auth_label_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void auth_label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }


        private void TimerProcessor(Object myObject, EventArgs myEventArgs)
        {
            Messenger.Message msg = new Messenger.Message("system", "", DateTime.UtcNow, 0, 0, 0);
            
            if (MessageID == 5)
            {
                API.SendMessage(msg);
                MessageID = 0;
                return;
            }
            else
            {
                msg = API.GetMessage(MessageID);
            }
            

            //Console.WriteLine("msg id: " + MessageID);
            //Console.WriteLine("msg: " + msg);
            //Console.WriteLine("msg text: " + msg.MessageText);

            //if (msg != null && msg.UserID == 0 && msg.MessageText == "Server is clear")
            //{
            //    MessageID = 0;
            //    return;
            //}

            if (msg != null && ((msg.UserID == AuthorizationForm.UserID && msg.ReceiverID == Convert.ToInt32(contactID)) || (msg.UserID == Convert.ToInt32(contactID) && msg.ReceiverID == AuthorizationForm.UserID)))
            {
                MessageslistBox.Items.Add(msg);
                MessageID++;
                //msg = API.GetMessage(MessageID);    
            }
            else if (msg != null)
            {
                MessageID++;
            }
            
            

        }

        private void ContactslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageslistBox.Items.Clear();

            string selected_contact = (string)ContactslistBox.SelectedItem;
            if (selected_contact != null)
            {
                //contactID = selected_contact.Substring(selected_contact.Length - 3).Substring(0, 2);

                int.TryParse(string.Join("", selected_contact.Where(c => char.IsDigit(c))), out contactID);

                DataBase db = new DataBase();

                string query = "SELECT chat_id FROM chat WHERE (user_1 = @user_1 AND user_2 = @user_2) OR (user_1 = @user_2 AND user_2 = @user_1);";

                MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                command.Parameters.Add("@user_1", MySqlDbType.VarChar).Value = AuthorizationForm.UserID;
                command.Parameters.Add("@user_2", MySqlDbType.VarChar).Value = contactID;
                         
                db.OpenConnection();

                MySqlDataReader reader;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    chatID = reader.GetInt32(0);
                }

                reader.Close();

                string query_old_messages = "SELECT users.user_id, users.first_name, users.second_name, s.chat_id, s.content, s.send_date FROM(SELECT message.chat_id, message.sender_id, content.content, message.send_date FROM content JOIN message ON content.content_id = message.content_id WHERE message.chat_id = @chat_id) s JOIN users ON users.user_id = s.sender_id;";

                MySqlCommand command_old_messages = new MySqlCommand(query_old_messages, db.GetConnection());

                command_old_messages.Parameters.Add("@chat_id", MySqlDbType.VarChar).Value = chatID;

                reader = command_old_messages.ExecuteReader();

                while (reader.Read())
                {
                    userName = reader.GetString(1) + " " + reader.GetString(2);
                    Messenger.Message msg_old = new Messenger.Message(userName, reader.GetString(4), reader.GetDateTime(5), reader.GetInt32(0), 0, chatID);
                    MessageslistBox.Items.Add(msg_old);

                    Console.WriteLine("msg from db:" + msg_old);
                }


                reader.Close();
                db.CloseConnection();

                MessageID = 0;

                timer1.Stop();

           
                timer1.Tick += new EventHandler(TimerProcessor);

                timer1.Interval = 1000;
                timer1.Start();
            }
            else
            {
                MessageID = 0;
                return;
            }
            
        }


        private void send_button_Click(object sender, EventArgs e)
        {
            string Message = MessagesrichTB.Text;
            
            if (userName != null)
            {
                Messenger.Message msg = new Messenger.Message(userName, Message, DateTime.Now, AuthorizationForm.UserID, Convert.ToInt32(contactID), chatID); //edit 2(chatID)
                API.SendMessage(msg);
            }
            MessagesrichTB.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            userName = AuthorizationForm.UserName;
            
            user_name_label.Text = userName;

            DataBase db = new DataBase();

            string query = $"SELECT users.user_id, users.first_name, users.second_name FROM users JOIN chat ON users.user_id = chat.user_1 AND chat.user_2 = {AuthorizationForm.UserID} UNION SELECT users.user_id, users.first_name, users.second_name FROM users JOIN chat ON users.user_id = chat.user_2 AND chat.user_1 = {AuthorizationForm.UserID};";
                //$"SELECT users.user_id, contacts.{AuthorizationForm.UserID}, users.first_name, users.second_name FROM users INNER JOIN contacts ON users.user_id=contacts.id WHERE contacts.{AuthorizationForm.UserID} IS NOT NULL";

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            db.OpenConnection();

            MySqlDataReader reader;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                ID = reader.GetInt32(0);
                contact = reader.GetString(1) + " " + reader.GetString(2);
                ContactslistBox.Items.Add($"{contact} (id:{ID})");
            }

            reader.Close();
            db.CloseConnection();

        }

        private void new_contact_button_Click(object sender, EventArgs e)
        {
            ContactsListForm contactsListForm = new ContactsListForm(this);
            contactsListForm.Show();
        }



        public void update_ContactslistBox()
        {
            ContactslistBox.Items.Clear();
            DataBase db = new DataBase();

            string query = $"SELECT users.user_id, users.first_name, users.second_name FROM users JOIN chat ON users.user_id = chat.user_1 AND chat.user_2 = {AuthorizationForm.UserID} UNION SELECT users.user_id, users.first_name, users.second_name FROM users JOIN chat ON users.user_id = chat.user_2 AND chat.user_1 = {AuthorizationForm.UserID};";

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            db.OpenConnection();

            MySqlDataReader reader;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                ID = reader.GetInt32(0);
                contact = reader.GetString(1) + " " + reader.GetString(2);
                ContactslistBox.Items.Add($"{contact} (id:{ID})");
            }

            reader.Close();
            db.CloseConnection();
        }
    }
}
