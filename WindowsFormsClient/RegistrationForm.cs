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
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;



namespace WindowsFormsClient
{
    public partial class RegistrationForm : Form
    {
        static readonly Protection gen = new Protection();
        //private int UserID;
        private int intNameCatcher;
        private int PhoneLength { get; set; }
        
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

            job_comboBox.Text = "Введите должность";
            job_comboBox.ForeColor = Color.Gray;

            phone_textBox.Text = "Введите номер телефона";
            phone_textBox.ForeColor = Color.Gray;

            mail_textBox.Text = "Введите почту";
            mail_textBox.ForeColor = Color.Gray;
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
                MessageBox.Show("Введите имя", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (intNameCatcher != 0)
            {                
                MessageBox.Show("Некорректное имя: имя содержит цифры", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (userSecondName_textBox.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (intSecNameCatcher != 0)
            {
                MessageBox.Show("Некорректная фамилия: фамилия содержит цифры", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (login_textBox.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (password_textBox.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (password_textBox.Text.Length < 8)
            {
                MessageBox.Show("Слишком короткий пароль. Длина пароля должна быть не менее 8 символов", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Неккоректный символ в пароле: " + password_textBox.Text[i], "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }           
                }
            }

            if (job_comboBox.Text == "Введите должность")
            {
                MessageBox.Show("Введите свою должность", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!job_comboBox.Items.Contains(job_comboBox.Text))
            {
                MessageBox.Show("Такой должности не существует", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (phone_textBox.Text == "Введите номер телефона")
            {
                MessageBox.Show("Введите свой номер телефона", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (phone_textBox.Text.Length < 11)
            {
                MessageBox.Show("Номер телефона слишком короткий", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else 
            {                                 
                if (phone_textBox.Text.Any(c => char.IsLetter(c)))
                {
                    MessageBox.Show("В номере телефона присутствует буква", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }                
            }



            if (mail_textBox.Text == "Введите почту")
            {
                MessageBox.Show("Введите свою почту", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ismailValid(mail_textBox.Text))
            {
                MessageBox.Show("Проверьте правильность почтового адреса", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (isUserExists())
                return;

            DataBase db = new DataBase();

            string query = "INSERT INTO `users` (`login`, `password`, `first_name`, `second_name`, `job_name`, `phone`, `mail`, `key_e`, `key_n`) VALUES (@login, @password, @name, @surname, @job, @phone, @mail, @key_e, @key_n)";
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
            command.Parameters.Add("@job", MySqlDbType.VarChar).Value = job_comboBox.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = PhoneMask(phone_textBox.Text);
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail_textBox.Text;
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

            do
            {
                db.OpenConnection();
            } while (!db.connect_flag);

            if (command.ExecuteNonQuery() == 1)
            {
                //MySqlDataReader reader;
                //reader = command_for_user_id.ExecuteReader();

                //while (reader.Read())
                //{
                //    UserID = reader.GetInt32(0);
                //}

                //reader.Close();

                //string query_for_add_new_columns = "ALTER TABLE `contacts` ADD `" + UserID.ToString() + "` LONGTEXT CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL";
                //string query_for_add_new_rows = "INSERT INTO `contacts` (`id`) VALUES ('" + UserID.ToString() + "')";

                //MySqlCommand command_for_add_new_columns = new MySqlCommand(query_for_add_new_columns, db.GetConnection());
                //MySqlCommand command_for_add_new_rows = new MySqlCommand(query_for_add_new_rows, db.GetConnection());

                //command_for_add_new_columns.ExecuteNonQuery();
                //command_for_add_new_rows.ExecuteNonQuery();

                MessageBox.Show("Приятного пользования!", "Аккаунт создан", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
            else
                MessageBox.Show("Произошла какая-то ошибка. Попробуйте снова или обратитесь к администратору.", "Аккаунт не был создан", MessageBoxButtons.OK, MessageBoxIcon.Error);



            do
            {
                db.CloseConnection();
            } while (!db.connect_flag);

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

            bool connect_flag = false;

            do
            {
                try
                {
                    adapter.Fill(table);
                    connect_flag = true;
                }
                catch (MySqlException)
                {
                    var result = MessageBox.Show("Обратитесь к администратору", "Не удалось подключиться к серверу", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                        return true;
                    }

                }
            } while (!connect_flag);

            

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

        private void RegistrationForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.White, 4);
            pen.LineJoin = LineJoin.Bevel;//задаем скошенные углы
            pen.MiterLimit = 4;//задаем ограничение толщины скошенных углов
            g.DrawRectangle(pen, new Rectangle(userFirstName_textBox.Location.X - 1, userFirstName_textBox.Location.Y - 1, userFirstName_textBox.Width + 3, userFirstName_textBox.Height + 3));
            g.DrawRectangle(pen, new Rectangle(userSecondName_textBox.Location.X - 1, userSecondName_textBox.Location.Y - 1, userSecondName_textBox.Width + 3, userSecondName_textBox.Height + 3));
            g.DrawRectangle(pen, new Rectangle(login_textBox.Location.X - 1, login_textBox.Location.Y - 1, login_textBox.Width + 3, login_textBox.Height + 3));
            g.DrawRectangle(pen, new Rectangle(password_textBox.Location.X - 1, password_textBox.Location.Y - 1, password_textBox.Width + 3, password_textBox.Height + 3));

            g.DrawRectangle(pen, new Rectangle(job_comboBox.Location.X - 1, job_comboBox.Location.Y - 1, job_comboBox.Width + 3, job_comboBox.Height + 3));

            g.DrawRectangle(pen, new Rectangle(phone_textBox.Location.X - 1, phone_textBox.Location.Y - 1, phone_textBox.Width + 3, phone_textBox.Height + 3));
            g.DrawRectangle(pen, new Rectangle(mail_textBox.Location.X - 1, mail_textBox.Location.Y - 1, mail_textBox.Width + 3, mail_textBox.Height + 3));

            //рисуем прямоугольник с параметрами испоьзуемыми выше            
            // ex Hermein
        }


        private void job_comboBox_Enter(object sender, EventArgs e)
        {
            if (job_comboBox.Text == "Введите должность")
            {
                job_comboBox.Text = "";
                job_comboBox.ForeColor = Color.Black;
            }
        }

        private void job_comboBox_Leave(object sender, EventArgs e)
        {
            if (job_comboBox.Text == "")
            {
                job_comboBox.Text = "Введите должность";
                job_comboBox.ForeColor = Color.Gray;
            }
        }

        private void phone_textBox_Enter(object sender, EventArgs e)
        {
            if (phone_textBox.Text == "Введите номер телефона")
            {
                phone_textBox.Text = "";
                phone_textBox.ForeColor = Color.Black;
            }
        }

        private void phone_textBox_Leave(object sender, EventArgs e)
        {
            if (phone_textBox.Text == "")
            {
                phone_textBox.Text = "Введите номер телефона";
                phone_textBox.ForeColor = Color.Gray;
            }
        }

        private void mail_textBox_Enter(object sender, EventArgs e)
        {
            if (mail_textBox.Text == "Введите почту")
            {
                mail_textBox.Text = "";
                mail_textBox.ForeColor = Color.Black;
            }
        }

        private void mail_textBox_Leave(object sender, EventArgs e)
        {
            if (mail_textBox.Text == "")
            {
                mail_textBox.Text = "Введите почту";
                mail_textBox.ForeColor = Color.Gray;
            }
        }

        
        private string PhoneMask(string Phone)
        {
            var newVal = Regex.Replace(Phone, @"[^0-9]", "");
            if (PhoneLength != newVal.Length && !string.IsNullOrEmpty(newVal))
            {
                PhoneLength = newVal.Length;
                Phone = string.Empty;
                
                    if (newVal.Length > 9)
                    {

                        Phone = Regex.Replace(newVal, @"(\d{1})(\d{3})(\d{0,3})(\d{0,2})(\d{0,2})", "8 ($2) $3-$4-$5");
                    }                                    
            }
            return Phone;
        }

        bool ismailValid(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

    }
}
