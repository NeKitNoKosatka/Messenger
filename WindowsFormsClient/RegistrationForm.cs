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
    public partial class RegistrationForm : Form
    {
        static readonly Protection gen = new Protection();
        private int UserID;
        private int intNameCatcher;
        private int intSecNameCatcher;

        private readonly string characters = "1234567890!@#$%^&*()_+-=\\№;:?/.,''<>|{}[]\"АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯйцуке`нгшщзхъфывапролджэячсмитьбю ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        //static string txt = "ПРИВЕТ";
        //static readonly Generator generator = new Generator();


        public RegistrationForm()
        {
            InitializeComponent();

            userFirstName_textBox.Text = "Введите имя";
            userFirstName_textBox.ForeColor = Color.Gray;

            userSecondName_textBox.Text = "Введите фамилию";
            userSecondName_textBox.ForeColor = Color.Gray;

            login_textBox.Text = "Введите логин";
            login_textBox.ForeColor = Color.Gray;
            
            password_textBox.Text = "Введите пароль";
            password_textBox.ForeColor = Color.Gray;
            password_textBox.UseSystemPasswordChar = false;
        }

        private void userFirstName_textBox_Enter(object sender, EventArgs e)
        {
            if (userFirstName_textBox.Text == "Введите имя")
            {
                userFirstName_textBox.Text = "";
                userFirstName_textBox.ForeColor = Color.Black;
            }
            
        }

        private void userFirstName_textBox_Leave(object sender, EventArgs e)
        {
            if (userFirstName_textBox.Text == "")
            {
                userFirstName_textBox.Text = "Введите имя";
                userFirstName_textBox.ForeColor = Color.Gray;
            }

            
        }

        private void userSecondName_textBox_Enter(object sender, EventArgs e)
        {
            if (userSecondName_textBox.Text == "Введите фамилию")
            {
                userSecondName_textBox.Text = "";
                userSecondName_textBox.ForeColor = Color.Black;
            }
        }

        private void userSecondName_textBox_Leave(object sender, EventArgs e)
        {
            if (userSecondName_textBox.Text == "")
            {
                userSecondName_textBox.Text = "Введите фамилию";
                userSecondName_textBox.ForeColor = Color.Gray;
            }
        }

        private void password_button_Click(object sender, EventArgs e)
        {
            if (password_textBox.UseSystemPasswordChar == false)
                password_textBox.UseSystemPasswordChar = true;
            else
                password_textBox.UseSystemPasswordChar = false;
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            long[] Keys = gen.GenerateKeys();
            long Key_e = Keys[0];
            long Key_n = Keys[1];

            int.TryParse(string.Join("", userFirstName_textBox.Text.Where(c => char.IsDigit(c))), out intNameCatcher);
            int.TryParse(string.Join("", userSecondName_textBox.Text.Where(c => char.IsDigit(c))), out intSecNameCatcher);

            //long Key_d = Keys[2];

            if (userFirstName_textBox.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (intNameCatcher != 0)
            {                
                MessageBox.Show("Некорректное имя: имя содержит цифры");
                return;
            }
            
            if (userSecondName_textBox.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }

            if (intSecNameCatcher != 0)
            {
                MessageBox.Show("Некорректная Фамилия: фамилия содержит цифры");
                return;
            }

            if (login_textBox.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            
            if (password_textBox.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            else
            {
                for (int i = 0; i < password_textBox.Text.Length; i++)
                {
                    //Console.WriteLine($"c[{i}]: {password_textBox.Text[i]}");
                    //Console.WriteLine($"pass length: {password_textBox.Text.Length}");
                    //Console.WriteLine(characters.IndexOf(password_textBox.Text[i]));
                    if (characters.IndexOf(password_textBox.Text[i]) == -1)
                    {
                        MessageBox.Show("Неккоректный символ в пароле: " + password_textBox.Text[i]);
                        return;
                    }           
                }
            }

            if (isUserExists())
                return;

            DataBase db = new DataBase();

            string query = "INSERT INTO `users` (`login`, `password`, `first_name`, `second_name`, `key_e`, `key_n`) VALUES (@login, @password, @name, @surname, @key_e, @key_n)";
            //OleDbCommand command = new OleDbCommand(query, db.GetConnection());

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());


            //command.Parameters.Add("@login", OleDbType.WChar, 40).Value = login_textBox.Text;
            //command.Parameters.Add("@password", OleDbType.WChar, 30).Value = password_textBox.Text;
            //command.Parameters.Add("@name", OleDbType.WChar, 100).Value = userFirstName_textBox.Text;
            //command.Parameters.Add("@surname", OleDbType.WChar, 100).Value = userSecondName_textBox.Text;

            //static readonly List<string> msg1 = gen.Protect(txt, Key_e, Key_n);

            string password = gen.ToString(gen.Protect(password_textBox.Text, Key_e, Key_n));

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login_textBox.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userFirstName_textBox.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSecondName_textBox.Text;
            command.Parameters.Add("@key_e", MySqlDbType.VarChar).Value = Key_e.ToString();
            command.Parameters.Add("@key_n", MySqlDbType.VarChar).Value = Key_n.ToString();

            // string keys_file_name = @"\keys_" + login_textBox.Text + ".env";

            // string Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MessangerWFClient\keys";

            // string path_to_keys = Path + keys_file_name;


            //try
            // {
            //     StreamReader rs = new StreamReader(path_to_keys);
            //     if (rs.ReadLine() == "" || rs.ReadLine() == null)
            //     {
            //         rs.Close();
            //         StreamWriter sw = new StreamWriter(path_to_keys);
            //         foreach (long item in Keys)
            //             sw.WriteLine(item);
            //         sw.Close();
            //     }
            // }
            // catch (System.IO.FileNotFoundException)
            // {
            //     StreamWriter sw = new StreamWriter(path_to_keys);
            //     foreach (long item in Keys)
            //         sw.WriteLine(item);
            //     sw.Close();
            // }
            // catch (System.IO.DirectoryNotFoundException)
            // {
            //     Directory.CreateDirectory(Path);
            //     StreamWriter sw = new StreamWriter(path_to_keys);
            //     foreach (long item in Keys)
            //         sw.WriteLine(item);
            //     sw.Close();
            // }

            string query_for_user_id = "SELECT * FROM users WHERE login = @uL"; 

            MySqlCommand command_for_user_id = new MySqlCommand(query_for_user_id, db.GetConnection());

            command_for_user_id.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login_textBox.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {   
                MySqlDataReader reader;
                reader = command_for_user_id.ExecuteReader();

                while (reader.Read())
                {
                    UserID = reader.GetInt32(0);
                }

                reader.Close();

                string query_for_add_new_columns = "ALTER TABLE `contacts` ADD `" + UserID.ToString() + "` LONGTEXT CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL";
                string query_for_add_new_rows = "INSERT INTO `contacts` (`id`) VALUES ('" + UserID.ToString() + "')";

                MySqlCommand command_for_add_new_columns = new MySqlCommand(query_for_add_new_columns, db.GetConnection());
                MySqlCommand command_for_add_new_rows = new MySqlCommand(query_for_add_new_rows, db.GetConnection());

                command_for_add_new_columns.ExecuteNonQuery();
                command_for_add_new_rows.ExecuteNonQuery();

                MessageBox.Show("Аккаунт создан");
            }
                
            else
                MessageBox.Show("Аккаунт не был создан");

            db.CloseConnection();

            this.Hide();
            //this.Close();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }

        public Boolean isUserExists()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            //OleDbDataAdapter adapter = new OleDbDataAdapter();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string query = "SELECT * FROM users WHERE login = @uL";

            //OleDbCommand command = new OleDbCommand(query, db.GetConnection());

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login_textBox.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует");
                return true;
            }
            else
                return false;

        }

        private void closing_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closing_button_MouseEnter_1(object sender, EventArgs e)
        {
            closing_button.ForeColor = Color.Blue;
        }

        private void closing_button_MouseLeave(object sender, EventArgs e)
        {
            closing_button.ForeColor = Color.Black;
        }

        Point mousePoint;
        private void RegistrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void reg_label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        private void reg_label_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void register_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }

        private void login_textBox_Enter(object sender, EventArgs e)
        {
            if (login_textBox.Text == "Введите логин")
            {
                login_textBox.Text = "";
                login_textBox.ForeColor = Color.Black;
            }
        }

        private void login_textBox_Leave(object sender, EventArgs e)
        {
            if (login_textBox.Text == "")
            {
                login_textBox.Text = "Введите логин";
                login_textBox.ForeColor = Color.Gray;
            }
        }

        private void password_textBox_Enter(object sender, EventArgs e)
        {
            if (password_textBox.Text == "Введите пароль")
            {
                password_textBox.UseSystemPasswordChar = true;
                password_textBox.Text = "";
                password_textBox.ForeColor = Color.Black;
            }
        }

        private void password_textBox_Leave(object sender, EventArgs e)
        {
            if (password_textBox.Text == "")
            {
                password_textBox.UseSystemPasswordChar = false;
                password_textBox.Text = "Введите пароль";
                password_textBox.ForeColor = Color.Gray;
            }
        }
    }
}
