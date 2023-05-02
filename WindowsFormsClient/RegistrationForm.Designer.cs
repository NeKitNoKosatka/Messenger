
namespace WindowsFormsClient
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.enter_button = new System.Windows.Forms.Button();
            this.password_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.reg_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userSecondName_textBox = new System.Windows.Forms.TextBox();
            this.userFirstName_textBox = new System.Windows.Forms.TextBox();
            this.closing_button = new System.Windows.Forms.Button();
            this.register_link = new System.Windows.Forms.LinkLabel();
            this.job_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mail_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enter_button
            // 
            this.enter_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.enter_button.FlatAppearance.BorderSize = 0;
            this.enter_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter_button.Font = new System.Drawing.Font("HeliosBlackC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_button.Location = new System.Drawing.Point(116, 545);
            this.enter_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(203, 45);
            this.enter_button.TabIndex = 7;
            this.enter_button.Text = "ПРИНЯТЬ";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // password_button
            // 
            this.password_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.password_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.password_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.password_button.FlatAppearance.BorderSize = 0;
            this.password_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.password_button.Image = ((System.Drawing.Image)(resources.GetObject("password_button.Image")));
            this.password_button.Location = new System.Drawing.Point(366, 322);
            this.password_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_button.Name = "password_button";
            this.password_button.Size = new System.Drawing.Size(36, 26);
            this.password_button.TabIndex = 6;
            this.password_button.UseVisualStyleBackColor = false;
            this.password_button.Click += new System.EventHandler(this.password_button_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(178, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(185, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Логин";
            // 
            // password_textBox
            // 
            this.password_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_textBox.Location = new System.Drawing.Point(72, 326);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(288, 15);
            this.password_textBox.TabIndex = 5;
            this.password_textBox.UseSystemPasswordChar = true;
            this.password_textBox.Enter += new System.EventHandler(this.password_textBox_Enter);
            this.password_textBox.Leave += new System.EventHandler(this.password_textBox_Leave);
            // 
            // login_textBox
            // 
            this.login_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_textBox.Location = new System.Drawing.Point(72, 270);
            this.login_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(288, 15);
            this.login_textBox.TabIndex = 4;
            this.login_textBox.Enter += new System.EventHandler(this.login_textBox_Enter);
            this.login_textBox.Leave += new System.EventHandler(this.login_textBox_Leave);
            // 
            // reg_label
            // 
            this.reg_label.AutoSize = true;
            this.reg_label.Font = new System.Drawing.Font("GOST type A", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(134)))), ((int)(((byte)(131)))));
            this.reg_label.Location = new System.Drawing.Point(102, 48);
            this.reg_label.Name = "reg_label";
            this.reg_label.Size = new System.Drawing.Size(225, 42);
            this.reg_label.TabIndex = 1;
            this.reg_label.Text = "РЕГИСТРАЦИЯ";
            this.reg_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reg_label_MouseDown);
            this.reg_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.reg_label_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(169, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(195, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Имя";
            // 
            // userSecondName_textBox
            // 
            this.userSecondName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userSecondName_textBox.Location = new System.Drawing.Point(72, 196);
            this.userSecondName_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userSecondName_textBox.Name = "userSecondName_textBox";
            this.userSecondName_textBox.Size = new System.Drawing.Size(288, 15);
            this.userSecondName_textBox.TabIndex = 3;
            this.userSecondName_textBox.Enter += new System.EventHandler(this.userSecondName_textBox_Enter);
            this.userSecondName_textBox.Leave += new System.EventHandler(this.userSecondName_textBox_Leave);
            // 
            // userFirstName_textBox
            // 
            this.userFirstName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userFirstName_textBox.Location = new System.Drawing.Point(72, 140);
            this.userFirstName_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userFirstName_textBox.Name = "userFirstName_textBox";
            this.userFirstName_textBox.Size = new System.Drawing.Size(287, 15);
            this.userFirstName_textBox.TabIndex = 2;
            this.userFirstName_textBox.Enter += new System.EventHandler(this.userFirstName_textBox_Enter);
            this.userFirstName_textBox.Leave += new System.EventHandler(this.userFirstName_textBox_Leave);
            // 
            // closing_button
            // 
            this.closing_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closing_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closing_button.FlatAppearance.BorderSize = 0;
            this.closing_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.closing_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.closing_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closing_button.Location = new System.Drawing.Point(389, 10);
            this.closing_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closing_button.Name = "closing_button";
            this.closing_button.Size = new System.Drawing.Size(36, 26);
            this.closing_button.TabIndex = 18;
            this.closing_button.Text = "X";
            this.closing_button.UseVisualStyleBackColor = true;
            this.closing_button.Click += new System.EventHandler(this.closing_button_Click);
            this.closing_button.MouseEnter += new System.EventHandler(this.closing_button_MouseEnter_1);
            this.closing_button.MouseLeave += new System.EventHandler(this.closing_button_MouseLeave);
            // 
            // register_link
            // 
            this.register_link.AutoSize = true;
            this.register_link.Location = new System.Drawing.Point(130, 612);
            this.register_link.Name = "register_link";
            this.register_link.Size = new System.Drawing.Size(171, 17);
            this.register_link.TabIndex = 8;
            this.register_link.TabStop = true;
            this.register_link.Text = "У меня уже есть аккаунт";
            this.register_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_link_LinkClicked);
            // 
            // job_comboBox
            // 
            this.job_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.job_comboBox.FormattingEnabled = true;
            this.job_comboBox.Items.AddRange(new object[] {
            "Генеральный директор",
            "Финансовый директор",
            "Технический директор",
            "Главный бухгалтер",
            "Секретарь",
            "Программист"});
            this.job_comboBox.Location = new System.Drawing.Point(72, 382);
            this.job_comboBox.Name = "job_comboBox";
            this.job_comboBox.Size = new System.Drawing.Size(288, 24);
            this.job_comboBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(160, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Должность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(169, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Телефон";
            // 
            // phone_textBox
            // 
            this.phone_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone_textBox.Location = new System.Drawing.Point(69, 442);
            this.phone_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(288, 15);
            this.phone_textBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(182, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Почта";
            // 
            // mail_textBox
            // 
            this.mail_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mail_textBox.Location = new System.Drawing.Point(69, 500);
            this.mail_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mail_textBox.Name = "mail_textBox";
            this.mail_textBox.Size = new System.Drawing.Size(288, 15);
            this.mail_textBox.TabIndex = 23;
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.enter_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.closing_button;
            this.ClientSize = new System.Drawing.Size(436, 666);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mail_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.job_comboBox);
            this.Controls.Add(this.register_link);
            this.Controls.Add(this.closing_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userSecondName_textBox);
            this.Controls.Add(this.userFirstName_textBox);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.password_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.reg_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RegistrationForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Button password_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.Label reg_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userSecondName_textBox;
        private System.Windows.Forms.TextBox userFirstName_textBox;
        private System.Windows.Forms.Button closing_button;
        private System.Windows.Forms.LinkLabel register_link;
        private System.Windows.Forms.ComboBox job_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mail_textBox;
    }
}