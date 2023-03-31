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
        private static string UserName = AuthorizationForm.UserName;
        private static MessengerClientAPI API = new MessengerClientAPI();
        private string contact;
        private int ID;
        private string contactID;

        public MainForm()
        {
            InitializeComponent();
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
            Messenger.Message msg = API.GetMessage(MessageID);

            if (msg != null && ((msg.UserID == AuthorizationForm.UserID && msg.ReceiverID == Convert.ToInt32(contactID)) || (msg.UserID == Convert.ToInt32(contactID) && msg.ReceiverID == AuthorizationForm.UserID)))
            {
                MessageslistBox.Items.Add(msg);
                MessageID++;
                msg = API.GetMessage(MessageID);    
            }
            else if (msg != null)
                MessageID++;
        }

        private void ContactslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_contact = (string)ContactslistBox.SelectedItem;
            if (selected_contact != null)
            {
                contactID = selected_contact.Substring(selected_contact.Length - 3).Substring(0, 2);

                MessageID = 0;

                timer1.Stop();

                MessageslistBox.Items.Clear();

                timer1.Tick += new EventHandler(TimerProcessor);

                timer1.Interval = 1000;
                timer1.Start();
            }
            else
            {
                return;
            }
            
        }


        private void send_button_Click(object sender, EventArgs e)
        {
            string Message = MessagesrichTB.Text;
            if (UserName != null)
            {
                Messenger.Message msg = new Messenger.Message(UserName, Message, DateTime.Now, AuthorizationForm.UserID, Convert.ToInt32(contactID), 2); //edit 2(chatID)
                API.SendMessage(msg);
            }
            MessagesrichTB.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            user_name_label.Text = UserName;

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
