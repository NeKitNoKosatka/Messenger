
namespace WindowsFormsClient
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.auth_label = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_button = new System.Windows.Forms.Button();
            this.enter_button = new System.Windows.Forms.Button();
            this.register_link = new System.Windows.Forms.LinkLabel();
            this.closing_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // auth_label
            // 
            this.auth_label.AutoSize = true;
            this.auth_label.Font = new System.Drawing.Font("GOST type A", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auth_label.ForeColor = System.Drawing.Color.SpringGreen;
            this.auth_label.Location = new System.Drawing.Point(112, 42);
            this.auth_label.Name = "auth_label";
            this.auth_label.Size = new System.Drawing.Size(233, 42);
            this.auth_label.TabIndex = 0;
            this.auth_label.Text = "АВТОРИЗАЦИЯ";
            this.auth_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.auth_label_MouseDown);
            this.auth_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.auth_label_MouseMove);
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(81, 125);
            this.login_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(288, 22);
            this.login_textBox.TabIndex = 1;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(81, 181);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(288, 22);
            this.password_textBox.TabIndex = 2;
            this.password_textBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(192, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(186, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // password_button
            // 
            this.password_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.password_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.password_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.password_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.password_button.Image = ((System.Drawing.Image)(resources.GetObject("password_button.Image")));
            this.password_button.Location = new System.Drawing.Point(373, 178);
            this.password_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_button.Name = "password_button";
            this.password_button.Size = new System.Drawing.Size(36, 26);
            this.password_button.TabIndex = 5;
            this.password_button.UseVisualStyleBackColor = false;
            this.password_button.Click += new System.EventHandler(this.password_button_Click);
            // 
            // enter_button
            // 
            this.enter_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.enter_button.FlatAppearance.BorderSize = 0;
            this.enter_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter_button.Font = new System.Drawing.Font("Gagalin", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_button.Location = new System.Drawing.Point(123, 255);
            this.enter_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(203, 45);
            this.enter_button.TabIndex = 6;
            this.enter_button.Text = "ВОЙТИ";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // register_link
            // 
            this.register_link.AutoSize = true;
            this.register_link.Location = new System.Drawing.Point(169, 315);
            this.register_link.Name = "register_link";
            this.register_link.Size = new System.Drawing.Size(105, 17);
            this.register_link.TabIndex = 7;
            this.register_link.TabStop = true;
            this.register_link.Text = "Нет аккаунта?";
            this.register_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_link_LinkClicked);
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
            this.closing_button.TabIndex = 14;
            this.closing_button.Text = "X";
            this.closing_button.UseVisualStyleBackColor = true;
            this.closing_button.Click += new System.EventHandler(this.closing_button_Click);
            this.closing_button.MouseEnter += new System.EventHandler(this.closing_button_MouseEnter);
            this.closing_button.MouseLeave += new System.EventHandler(this.closing_button_MouseLeave);
            // 
            // AuthorizationForm
            // 
            this.AcceptButton = this.enter_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.CancelButton = this.closing_button;
            this.ClientSize = new System.Drawing.Size(436, 360);
            this.Controls.Add(this.closing_button);
            this.Controls.Add(this.register_link);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.password_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.auth_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthorizationForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AuthorizationForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label auth_label;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button password_button;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.LinkLabel register_link;
        private System.Windows.Forms.Button closing_button;
    }
}