
namespace WindowsFormsClient
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.name_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.secondname_label = new System.Windows.Forms.Label();
            this.job_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.mail_label = new System.Windows.Forms.Label();
            this.mess_count_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.new_contact_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.plus_label = new System.Windows.Forms.Label();
            this.ContactslistBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MessageslistBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1261, 656);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(448, 305);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Controls.Add(this.name_label, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.secondname_label, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.job_label, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.phone_label, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.mail_label, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.mess_count_label, 2, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(27, 27);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(406, 263);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // name_label
            // 
            this.name_label.AutoEllipsis = true;
            this.name_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.Location = new System.Drawing.Point(170, 26);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(241, 25);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsClient.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(27, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel2.SetRowSpan(this.pictureBox1, 6);
            this.pictureBox1.Size = new System.Drawing.Size(137, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // secondname_label
            // 
            this.secondname_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondname_label.Location = new System.Drawing.Point(170, 51);
            this.secondname_label.Name = "secondname_label";
            this.secondname_label.Size = new System.Drawing.Size(241, 25);
            this.secondname_label.TabIndex = 2;
            this.secondname_label.Text = "SecondName";
            // 
            // job_label
            // 
            this.job_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.job_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.job_label.Location = new System.Drawing.Point(170, 76);
            this.job_label.Name = "job_label";
            this.job_label.Size = new System.Drawing.Size(241, 37);
            this.job_label.TabIndex = 2;
            this.job_label.Text = "Должность: ";
            this.job_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // phone_label
            // 
            this.phone_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_label.Location = new System.Drawing.Point(170, 113);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(241, 25);
            this.phone_label.TabIndex = 3;
            this.phone_label.Text = "Телефон: ";
            this.phone_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mail_label
            // 
            this.mail_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mail_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mail_label.Location = new System.Drawing.Point(170, 138);
            this.mail_label.Name = "mail_label";
            this.mail_label.Size = new System.Drawing.Size(241, 25);
            this.mail_label.TabIndex = 4;
            this.mail_label.Text = "Почта: ";
            // 
            // mess_count_label
            // 
            this.mess_count_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mess_count_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mess_count_label.Location = new System.Drawing.Point(170, 163);
            this.mess_count_label.Name = "mess_count_label";
            this.mess_count_label.Padding = new System.Windows.Forms.Padding(0, 0, 24, 0);
            this.mess_count_label.Size = new System.Drawing.Size(241, 69);
            this.mess_count_label.TabIndex = 5;
            this.mess_count_label.Text = "Всего сообщений: ";
            this.mess_count_label.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 314);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(448, 339);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.ContactslistBox, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(26, 14);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(408, 299);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // new_contact_button
            // 
            this.new_contact_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.new_contact_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.new_contact_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.new_contact_button.FlatAppearance.BorderSize = 0;
            this.new_contact_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.new_contact_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.new_contact_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_contact_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_contact_button.Location = new System.Drawing.Point(0, 0);
            this.new_contact_button.Margin = new System.Windows.Forms.Padding(0);
            this.new_contact_button.Name = "new_contact_button";
            this.new_contact_button.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.new_contact_button.Size = new System.Drawing.Size(408, 30);
            this.new_contact_button.TabIndex = 0;
            this.new_contact_button.Text = "Добавить контакт";
            this.new_contact_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_contact_button.UseVisualStyleBackColor = false;
            this.new_contact_button.Click += new System.EventHandler(this.new_contact_button_Click);
            this.new_contact_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.new_contact_button_MouseDown);
            this.new_contact_button.MouseEnter += new System.EventHandler(this.new_contact_button_MouseEnter);
            this.new_contact_button.MouseLeave += new System.EventHandler(this.new_contact_button_MouseLeave);
            this.new_contact_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.new_contact_button_MouseUp);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.plus_label);
            this.panel2.Controls.Add(this.new_contact_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 269);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 30);
            this.panel2.TabIndex = 1;
            // 
            // plus_label
            // 
            this.plus_label.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plus_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.plus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus_label.Location = new System.Drawing.Point(358, 0);
            this.plus_label.Margin = new System.Windows.Forms.Padding(0);
            this.plus_label.Name = "plus_label";
            this.plus_label.Padding = new System.Windows.Forms.Padding(0, 0, 24, 0);
            this.plus_label.Size = new System.Drawing.Size(50, 30);
            this.plus_label.TabIndex = 1;
            this.plus_label.Text = "+";
            this.plus_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ContactslistBox
            // 
            this.ContactslistBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactslistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactslistBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ContactslistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactslistBox.FormattingEnabled = true;
            this.ContactslistBox.ItemHeight = 30;
            this.ContactslistBox.Location = new System.Drawing.Point(0, 24);
            this.ContactslistBox.Margin = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.ContactslistBox.Name = "ContactslistBox";
            this.ContactslistBox.Size = new System.Drawing.Size(408, 245);
            this.ContactslistBox.TabIndex = 2;
            this.ContactslistBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ContactslistBox_DrawItem);
            this.ContactslistBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.ContactslistBox_MeasureItem);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.tableLayoutPanel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(457, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(801, 650);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(801, 650);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.MessageslistBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(12, 24);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(765, 602);
            this.panel3.TabIndex = 0;
            // 
            // MessageslistBox
            // 
            this.MessageslistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageslistBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MessageslistBox.FormattingEnabled = true;
            this.MessageslistBox.Location = new System.Drawing.Point(0, 0);
            this.MessageslistBox.Name = "MessageslistBox";
            this.MessageslistBox.Size = new System.Drawing.Size(765, 602);
            this.MessageslistBox.TabIndex = 0;
            this.MessageslistBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MessageslistBox_DrawItem);
            this.MessageslistBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.MessageslistBox_MeasureItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1261, 656);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(0, 703);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label job_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label mail_label;
        private System.Windows.Forms.Label mess_count_label;
        private System.Windows.Forms.Label secondname_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button new_contact_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label plus_label;
        private System.Windows.Forms.ListBox ContactslistBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox MessageslistBox;
    }
}