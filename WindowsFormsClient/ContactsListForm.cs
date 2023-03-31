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
    public partial class ContactsListForm : Form
    {
        private string contact;
        private int ID;
        private string new_contact;
        private int contactID;
        private MainForm mainForm;


        public ContactsListForm(MainForm f)
        {
            InitializeComponent();
            mainForm = f;           
        }

        private void ContactsListForm_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            string query = $"SELECT users.user_id, users.first_name, users.second_name FROM users WHERE user_id NOT IN (SELECT users.user_id FROM users JOIN chat ON users.user_id = chat.user_1 AND chat.user_2 = {AuthorizationForm.UserID} UNION SELECT users.user_id FROM users JOIN chat ON users.user_id = chat.user_2 AND chat.user_1 = {AuthorizationForm.UserID});";
            //$"SELECT users.user_id, contacts.{AuthorizationForm.UserID}, users.first_name, users.second_name FROM users INNER JOIN contacts ON users.user_id=contacts.id WHERE contacts.{AuthorizationForm.UserID} IS NULL";

            //string query = $"SELECT users.user_id, contacts.{AuthorizationForm.UserID}, users.first_name, users.second_name FROM users INNER JOIN contacts ON users.user_id=contacts.id WHERE contacts.{AuthorizationForm.UserID} IS NULL";

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

        private void ContactslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new_contact = (string)ContactslistBox.SelectedItem;
            
            string message = $"Будет создан диалог с {new_contact}";
            string caption = "Создать новый диалог?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(this, message, caption, buttons);
            
            if (result == DialogResult.Yes)
            {
                DataBase db = new DataBase();
                //int contactID;
                int.TryParse(string.Join("", new_contact.Where(c => char.IsDigit(c))), out contactID);
                
                string update_query_1 = $"INSERT INTO `chat` (`chat_id`, `user_1`, `user_2`) VALUES (NULL, {AuthorizationForm.UserID}, {contactID});";
               
                MySqlCommand update_command_1 = new MySqlCommand(update_query_1, db.GetConnection());

                db.OpenConnection();
                update_command_1.ExecuteNonQuery();
                db.CloseConnection();

                mainForm.update_ContactslistBox();


                // mainForm.ContactslistBox.Items.Add($"{contact} (id:{ID})");

                this.Close();
            }
        }


        Point mousePoint;

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        private void closing_button_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
