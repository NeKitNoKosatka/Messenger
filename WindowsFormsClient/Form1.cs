using Messenger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;


namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        private static int MessageID = 0;

        private static string userName; //= AuthorizationForm.UserName;
        private static MessengerClientAPI API = new MessengerClientAPI();
        private string job_name;
        private string phone;
        private string mail;
        private string contact;
        private int ID;
        private int contactID;
        private int chatID = -1;
        private int msg_count;

        


        public Form1()
        {
            InitializeComponent();
                        
        }

        



        

        private void TimerProcessor(Object myObject, EventArgs myEventArgs)
        {
            Messenger.Message msg = new Messenger.Message("system", "", DateTime.UtcNow, 0, 0, -1);

            bool connect_flag_2 = false;

            do
            {
                try
                {
                    API.GetMessage(0);
                    connect_flag_2 = true;
                }
                catch (System.Net.WebException)
                {
                    timer1.Stop();
                    var result = MessageBox.Show("Обратитесь к администратору", "Не удалось подключиться к серверу", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                        return;
                    }

                }
            } while (!connect_flag_2);

            timer1.Start();

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

            if (msg != null && ((msg.UserID == AuthorizationForm.UserID && msg.ReceiverID == Convert.ToInt32(contactID)) || (msg.UserID == Convert.ToInt32(contactID) && msg.ReceiverID == AuthorizationForm.UserID)))
            {
                MessageslistBox.Items.Add(msg);
                create_panel(msg);
                MessageID++;
                //msg = API.GetMessage(MessageID);    
            }
            else if (msg != null)
            {
                MessageID++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            string query = "SELECT `job_name`, `phone`, `mail` FROM `users` WHERE `user_id` = @user_id";

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            command.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = AuthorizationForm.UserID;
            

            do
            {
                db.OpenConnection();
            } while (!db.connect_flag);

            MySqlDataReader reader;
            reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                job_name = reader.GetString(0);
                phone = reader.GetString(1);
                mail = reader.GetString(2); 
            }
            reader.Close();

            do
            {
                db.CloseConnection();
            } while (!db.connect_flag);

            userName = AuthorizationForm.UserName;

            string[] name = userName.Split(' ');

            name_label.Text = name[0];
            secondname_label.Text = name[1];


            job_label.Text = "Должность: " + job_name;
            phone_label.Text = "Телефон: " + phone;
            mail_label.Text = "Почта: " + mail;
            mess_count_label.Text = "";



            string query_2 = $"SELECT users.user_id, users.first_name, users.second_name FROM users JOIN chat ON users.user_id = chat.user_1 AND chat.user_2 = {AuthorizationForm.UserID} UNION SELECT users.user_id, users.first_name, users.second_name FROM users JOIN chat ON users.user_id = chat.user_2 AND chat.user_1 = {AuthorizationForm.UserID};";

            MySqlCommand command_2 = new MySqlCommand(query_2, db.GetConnection());

            do
            {
                db.OpenConnection();
            } while (!db.connect_flag);

            
            reader = command_2.ExecuteReader();

            while (reader.Read())
            {
                ID = reader.GetInt32(0);
                contact = reader.GetString(1) + " " + reader.GetString(2);
                ContactslistBox.Items.Add($"{contact} (id:{ID})");
            }

            reader.Close();
            do
            {
                db.CloseConnection();
            } while (!db.connect_flag);


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            //AnimateWindow(this.Handle, 500, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_HIDE);
        }

        private void new_contact_button_MouseEnter(object sender, EventArgs e)
        {
            plus_label.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void new_contact_button_MouseLeave(object sender, EventArgs e)
        {
            plus_label.BackColor = SystemColors.ControlLight;
        }

        private void new_contact_button_Click(object sender, EventArgs e)
        {
            ContactsListForm contactsListForm = new ContactsListForm(this);
            contactsListForm.Show();
        }

        protected override void OnSizeChanged(EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Maximized)
            { //вызываем обновление компонента
                //Console.WriteLine(this.WindowState);
                MessageslistBox.Refresh();
                base.OnSizeChanged(e);
            }
        }

        


        private void ContactslistBox_DrawItem(object sender, DrawItemEventArgs e)
        {


            if (e.Index < 0) return;

            // задаем параметры для рисования текущего элемента
            // Если элемент имеет состояние 'выбран' мы изменяем цвет его кисти бэкграунда на желтую, 
            //остальные параемтры оставим по умолчанию взятые из параметра `e`
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.FromArgb(160, 231, 159));// <- обратить внимание сюда

            // Начинаем рисовать
            // Рисуем Background для каждого элемента
            e.DrawBackground();

            // Рисуем текст для каждого элемента
            e.Graphics.DrawString(ContactslistBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            //e.Graphics.DrawString(ContactslistBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);


            // если у текущеного элемента есть фокус, эта функция нарисует фокус
            e.DrawFocusRectangle();
        }

        private void new_contact_button_MouseDown(object sender, MouseEventArgs e)
        {
            plus_label.BackColor = SystemColors.ActiveCaption;
        }

        private void new_contact_button_MouseUp(object sender, MouseEventArgs e)
        {
            plus_label.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void ContactslistBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(ContactslistBox.Items[e.Index].ToString(), ContactslistBox.Font, ContactslistBox.Width).Height;
        }

        private void MessageslistBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(MessageslistBox.Items[e.Index].ToString(), MessageslistBox.Font, MessageslistBox.Width).Height;
            //e.ItemWidth = Width;
        }

        private void MessageslistBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // задаем параметры для рисования текущего элемента
            // Если элемент имеет состояние 'выбран' мы изменяем цвет его кисти бэкграунда на желтую, 
            //остальные параемтры оставим по умолчанию взятые из параметра `e`
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          Color.Black,
                                          Color.FromArgb(255,255,255));// <- обратить внимание сюда 160, 231, 159 e.ForeColor

            // Начинаем рисовать
            // Рисуем Background для каждого элемента
            e.DrawBackground();

            // Рисуем текст для каждого элемента
            //e.Graphics.DrawString(MessageslistBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            e.Graphics.DrawString(MessageslistBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);


            // если у текущеного элемента есть фокус, эта функция нарисует фокус
            e.DrawFocusRectangle();
        }

        private void send_button_MouseEnter(object sender, EventArgs e)
        {
            //send_button.ForeColor = Color.FromArgb(20, 148, 137);
        }

        private void send_button_MouseLeave(object sender, EventArgs e)
        {
            //send_button.ForeColor = Color.Black;
        }

        private void send_button_MouseDown(object sender, MouseEventArgs e)
        {
            send_button.ForeColor = Color.FromArgb(20, 148, 137);
            //send_button.ForeColor = Color.FromArgb(29, 203, 188);
        }

        private void send_button_MouseUp(object sender, MouseEventArgs e)
        {
            send_button.ForeColor = Color.Black;
            //send_button.ForeColor = Color.FromArgb(20, 148, 137);
        }

        private void richTextBox2_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            //((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
            //((RichTextBox)sender).Location = new Point(((RichTextBox)sender).Location.X, ((RichTextBox)sender).Location.Y - 16);

        }


        private void send_mess_button_MouseEnter(object sender, EventArgs e)
        {
            send_button_pictureBox.Image = Properties.Resources.send_button_back_pressed;
            
        }

        private void send_mess_button_MouseLeave(object sender, EventArgs e)
        {
            send_button_pictureBox.Image = Properties.Resources.send_button_back;
        }

        private void send_mess_button_MouseDown(object sender, MouseEventArgs e)
        {
            send_button_pictureBox.Image = Properties.Resources.send_button_back_mouse_down;
        }

        private void send_mess_button_MouseUp(object sender, MouseEventArgs e)
        {
            send_button_pictureBox.Image = Properties.Resources.send_button_back_pressed;
        }
        public void update_ContactslistBox()
        {
            ContactslistBox.Items.Clear();
            DataBase db = new DataBase();

            string query = $"SELECT users.user_id, users.first_name, users.second_name FROM users JOIN chat ON users.user_id = chat.user_1 AND chat.user_2 = {AuthorizationForm.UserID} UNION SELECT users.user_id, users.first_name, users.second_name FROM users JOIN chat ON users.user_id = chat.user_2 AND chat.user_1 = {AuthorizationForm.UserID};";

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            do
            {
                db.OpenConnection();
            } while (!db.connect_flag);

            MySqlDataReader reader;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                ID = reader.GetInt32(0);
                contact = reader.GetString(1) + " " + reader.GetString(2);
                ContactslistBox.Items.Add($"{contact} (id:{ID})");
            }

            reader.Close();
            do
            {
                db.CloseConnection();
            } while (!db.connect_flag);
        }

        private void ContactslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("selected index: " + ContactslistBox.SelectedIndex);
            if (ContactslistBox.SelectedIndex == -1)
                return;

            MessageslistBox.Items.Clear();
            while (MassageBox.Controls.Count > 0)
            {
                MassageBox.Controls[0].Dispose();
            }
            msg_count = 0;

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

                do
                {
                    db.OpenConnection();
                } while (!db.connect_flag);

                MySqlDataReader reader;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    chatID = reader.GetInt32(0);
                }

                reader.Close();

                string query_old_messages = "SELECT users.user_id, users.first_name, users.second_name, s.chat_id, s.content, s.send_date FROM(SELECT message.chat_id, message.sender_id, content.content, message.send_date FROM content JOIN message ON content.content_id = message.content_id WHERE message.chat_id = @chat_id) s JOIN users ON users.user_id = s.sender_id ORDER BY s.send_date ASC;";

                MySqlCommand command_old_messages = new MySqlCommand(query_old_messages, db.GetConnection());

                command_old_messages.Parameters.Add("@chat_id", MySqlDbType.VarChar).Value = chatID;

                string query_info = "SELECT `job_name`, `phone`, `mail` FROM `users` WHERE `user_id` = @user_id";

                MySqlCommand command_info = new MySqlCommand(query_info, db.GetConnection());

                command_info.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = AuthorizationForm.UserID;

                reader = command_old_messages.ExecuteReader();

                while (reader.Read())
                {
                    userName = reader.GetString(1) + " " + reader.GetString(2);
                    Messenger.Message msg_old = new Messenger.Message(userName, reader.GetString(4), reader.GetDateTime(5), reader.GetInt32(0), 0, chatID);
                    MessageslistBox.Items.Add(msg_old);
                    create_panel(msg_old);

                    msg_count += 1;

                    //Console.WriteLine("msg from db:" + msg_old);
                }

                reader.Close();

                reader = command_info.ExecuteReader();

                while (reader.Read())
                {
                    job_name = reader.GetString(0);
                    phone = reader.GetString(1);
                    mail = reader.GetString(2);
                }
                reader.Close();


                do
                {
                    db.CloseConnection();
                } while (!db.connect_flag);

                string[] name = contact.Split(' ');

                name_label.Text = name[0];
                secondname_label.Text = name[1];
                job_label.Text = "Должность: " + job_name;
                phone_label.Text = "Телефон: " + phone;
                mail_label.Text = "Почта: " + mail;
                mess_count_label.Text = "Всего сообщений: " + msg_count.ToString();

                MessageID = 0;

                timer1.Stop();


                timer1.Tick += new EventHandler(TimerProcessor);

                timer1.Interval = 1; //интервал таймера, запрашивающего новые сообщения у сервера
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
            userName = AuthorizationForm.UserName;

            bool connect_flag = false;
            Messenger.Message msg = new Messenger.Message(userName, Message, DateTime.Now, AuthorizationForm.UserID, Convert.ToInt32(contactID), chatID); //edit 2(chatID)
            
            do
            {
                try
                {
                    
                    API.SendMessage(msg);
                    connect_flag = true;
                }
                catch (System.Net.WebException)
                {
                    var result = MessageBox.Show("Обратитесь к администратору", "Не удалось подключиться к серверу", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                        return;
                    }

                }
            } while (!connect_flag);

            MessagesrichTB.Text = "";


            //create_panel(msg);
            //chek = !chek;   //temp
        }


        private void create_panel(Messenger.Message msg)
        {

            //Console.WriteLine("msg: " + msg);
            //Console.WriteLine("sender id: " + msg.UserID);
            bool chek = isSender(msg);
            string text = msg.MessageText;

            Label text_label = new Label();
            Label time_label = new Label();


            text_label.Text = text;
            time_label.Text = msg.TimeStamp.ToShortTimeString();

            Font stringFont = new Font("Arial", 13);
            text_label.Width = 180;
            text_label.Font = stringFont;
            text_label.Dock = DockStyle.Fill;
            text_label.Padding = new Padding(5);
            text_label.AutoSize = true;
            text_label.AutoEllipsis = true;
            text_label.MaximumSize = new Size(307, 0);
            text_label.MinimumSize = new Size(60, 0);

            Font timestringFont = new Font("Arial", 7);
            time_label.Font = timestringFont;
            time_label.Dock = DockStyle.Bottom;
            time_label.TextAlign = ContentAlignment.MiddleRight;

            Panel panel_min = new Panel();

            panel_min.AutoSize = true;
            panel_min.MaximumSize = new Size(327, 0);

            if (chek)   
            {
                panel_min.BackColor = Color.FromArgb(202, 255, 252);
                panel_min.Anchor = AnchorStyles.Right;
            }
            else
            {                
                panel_min.BackColor = Color.FromArgb(245, 245, 245);
                panel_min.Anchor = AnchorStyles.Left;
            }

            panel_min.Parent = MassageBox;
            text_label.Parent = panel_min;
            time_label.Parent = panel_min;

            MassageBox.ScrollControlIntoView(panel_min);
        }

        private bool isSender(Messenger.Message msg)
        {
            if (msg.UserID == AuthorizationForm.UserID)
                return true;
            else
                return false;
        }


    }
}
