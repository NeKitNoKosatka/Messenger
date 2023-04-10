using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class AuthorizationForm : Form
    {
        private static readonly Protection protection = new Protection();
        private string loginUser;
        private string passUser_db;
        private long key_e;
        private long key_n;
        public static string UserName;
        public static int UserID;
        public MainForm mainForm = new MainForm();

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        //public string GetUserName()
        //{
        //    return UserName;
        //}

        private void password_button_Click(object sender, EventArgs e)
        {
            if (password_textBox.UseSystemPasswordChar == false)
                password_textBox.UseSystemPasswordChar = true;
            else
                password_textBox.UseSystemPasswordChar = false;
        }

        

        private void enter_button_Click(object sender, EventArgs e)
        {

            
            loginUser = login_textBox.Text; //gen.ToString(gen.Protect(login_textBox.Text, Key_e, Key_n));
            

            List<string> passUser_enter = new List<string>();
           
            //long[] Keys = new long[3];

            DataBase db = new DataBase();

            //DataTable table = new DataTable();

            //OleDbDataAdapter adapter = new OleDbDataAdapter();

            //MySqlDataAdapter adapter = new MySqlDataAdapter();

            string query = "SELECT * FROM users WHERE login = @uL"; // AND password = @uP";

            //OleDbCommand command = new OleDbCommand(query, db.GetConnection());

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            //command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            

            db.OpenConnection();
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                
                passUser_db = reader.GetString(2);
                
                UserName = reader.GetString(3) + " " + reader.GetString(4);
                
                UserID = reader.GetInt32(0);
                
                key_e = reader.GetInt32(5);
                key_n = reader.GetInt32(6);
                //Console.WriteLine(reader.GetString(2) + ", " + reader.GetInt32(5) + ", " + reader.GetInt32(6));
            }
     
            
            reader.Close();
            
            db.CloseConnection();

            //command.Parameters.Add("@uL", OleDbType.VarChar).Value = loginUser;
            //command.Parameters.Add("@uP", OleDbType.VarChar).Value = passUser;


            //string keys_file_name = @"\keys_" + login_textBox.Text + ".env";

            //string Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MessangerWFClient\keys";

            //string path_to_keys = Path + keys_file_name;


            //StreamReader rs = new StreamReader(path_to_keys);
            //    for (int i = 0; i < 3; i++)
            //        Keys[i] = Convert.ToInt64(rs.ReadLine());

            //rs.Close();

            //passUser_enter = protection.Protect(password_textBox.Text, Keys[0], Keys[1]);
            if (key_n != 0)
            {
                passUser_enter = protection.Protect(password_textBox.Text, key_e, key_n);
            }
            else
            {
                passUser_db = null;
            }

            //adapter.SelectCommand = command;
            //adapter.Fill(table);

            if (protection.ToString(passUser_enter) == passUser_db) //(table.Rows.Count > 0)
            {
                this.Hide();
                
                mainForm.Show();
            }
            else
                MessageBox.Show("Проверьте правильность ввода логина и пароля");

        }

        private void register_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void closing_button_MouseEnter(object sender, EventArgs e)
        {
            closing_button.ForeColor = Color.Blue;
            
        }

        private void closing_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closing_button_MouseLeave(object sender, EventArgs e)
        {
            closing_button.ForeColor = Color.Black;
        }

        Point mousePoint;
        private void AuthorizationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        private void AuthorizationForm_MouseDown(object sender, MouseEventArgs e)
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

        private void auth_label_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }
    }
}
