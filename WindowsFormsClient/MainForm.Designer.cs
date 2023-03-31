﻿
namespace WindowsFormsClient
{
    public partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.auth_label = new System.Windows.Forms.Label();
            this.closing_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.user_name_label = new System.Windows.Forms.Label();
            this.ContactsContainer = new System.Windows.Forms.SplitContainer();
            this.new_contact_button = new System.Windows.Forms.Button();
            this.ContactslistBox = new System.Windows.Forms.ListBox();
            this.send_button = new System.Windows.Forms.Button();
            this.MessagesrichTB = new System.Windows.Forms.RichTextBox();
            this.MessageslistBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsContainer)).BeginInit();
            this.ContactsContainer.Panel1.SuspendLayout();
            this.ContactsContainer.Panel2.SuspendLayout();
            this.ContactsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // auth_label
            // 
            this.auth_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.auth_label.AutoSize = true;
            this.auth_label.Font = new System.Drawing.Font("GOST type A", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth_label.ForeColor = System.Drawing.Color.MintCream;
            this.auth_label.Location = new System.Drawing.Point(25, 7);
            this.auth_label.Name = "auth_label";
            this.auth_label.Size = new System.Drawing.Size(131, 32);
            this.auth_label.TabIndex = 7;
            this.auth_label.Text = "КОНТАКТЫ";
            this.auth_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.auth_label_MouseDown);
            this.auth_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.auth_label_MouseMove);
            // 
            // closing_button
            // 
            this.closing_button.BackColor = System.Drawing.Color.Aquamarine;
            this.closing_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closing_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closing_button.FlatAppearance.BorderSize = 0;
            this.closing_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.closing_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.closing_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closing_button.Location = new System.Drawing.Point(665, 10);
            this.closing_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closing_button.Name = "closing_button";
            this.closing_button.Size = new System.Drawing.Size(36, 26);
            this.closing_button.TabIndex = 13;
            this.closing_button.Text = "X";
            this.closing_button.UseVisualStyleBackColor = false;
            this.closing_button.Click += new System.EventHandler(this.closing_button_Click);
            this.closing_button.MouseEnter += new System.EventHandler(this.closing_button_MouseEnter);
            this.closing_button.MouseLeave += new System.EventHandler(this.closing_button_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.user_name_label);
            this.panel1.Controls.Add(this.auth_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 48);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // user_name_label
            // 
            this.user_name_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user_name_label.AutoSize = true;
            this.user_name_label.Font = new System.Drawing.Font("GOST type A", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_name_label.ForeColor = System.Drawing.Color.MintCream;
            this.user_name_label.Location = new System.Drawing.Point(356, 7);
            this.user_name_label.Name = "user_name_label";
            this.user_name_label.Size = new System.Drawing.Size(134, 32);
            this.user_name_label.TabIndex = 8;
            this.user_name_label.Text = "user_name";
            // 
            // ContactsContainer
            // 
            this.ContactsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactsContainer.Location = new System.Drawing.Point(0, 48);
            this.ContactsContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContactsContainer.Name = "ContactsContainer";
            // 
            // ContactsContainer.Panel1
            // 
            this.ContactsContainer.Panel1.BackColor = System.Drawing.Color.LightCyan;
            this.ContactsContainer.Panel1.Controls.Add(this.new_contact_button);
            this.ContactsContainer.Panel1.Controls.Add(this.ContactslistBox);
            // 
            // ContactsContainer.Panel2
            // 
            this.ContactsContainer.Panel2.BackColor = System.Drawing.Color.MintCream;
            this.ContactsContainer.Panel2.Controls.Add(this.send_button);
            this.ContactsContainer.Panel2.Controls.Add(this.MessagesrichTB);
            this.ContactsContainer.Panel2.Controls.Add(this.MessageslistBox);
            this.ContactsContainer.Size = new System.Drawing.Size(726, 354);
            this.ContactsContainer.SplitterDistance = 191;
            this.ContactsContainer.TabIndex = 16;
            // 
            // new_contact_button
            // 
            this.new_contact_button.AutoSize = true;
            this.new_contact_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.new_contact_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_contact_button.FlatAppearance.BorderSize = 0;
            this.new_contact_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_contact_button.Image = global::WindowsFormsClient.Properties.Resources.plus;
            this.new_contact_button.Location = new System.Drawing.Point(17, 310);
            this.new_contact_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.new_contact_button.Name = "new_contact_button";
            this.new_contact_button.Size = new System.Drawing.Size(30, 30);
            this.new_contact_button.TabIndex = 8;
            this.new_contact_button.UseVisualStyleBackColor = true;
            this.new_contact_button.Click += new System.EventHandler(this.new_contact_button_Click);
            // 
            // ContactslistBox
            // 
            this.ContactslistBox.BackColor = System.Drawing.Color.LightCyan;
            this.ContactslistBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactslistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactslistBox.FormattingEnabled = true;
            this.ContactslistBox.ItemHeight = 16;
            this.ContactslistBox.Location = new System.Drawing.Point(0, 0);
            this.ContactslistBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContactslistBox.Name = "ContactslistBox";
            this.ContactslistBox.Size = new System.Drawing.Size(191, 354);
            this.ContactslistBox.TabIndex = 0;
            this.ContactslistBox.SelectedIndexChanged += new System.EventHandler(this.ContactslistBox_SelectedIndexChanged);
            // 
            // send_button
            // 
            this.send_button.AutoSize = true;
            this.send_button.FlatAppearance.BorderSize = 0;
            this.send_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_button.Image = global::WindowsFormsClient.Properties.Resources.send;
            this.send_button.Location = new System.Drawing.Point(477, 310);
            this.send_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(48, 40);
            this.send_button.TabIndex = 2;
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // MessagesrichTB
            // 
            this.MessagesrichTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessagesrichTB.Location = new System.Drawing.Point(4, 310);
            this.MessagesrichTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MessagesrichTB.Name = "MessagesrichTB";
            this.MessagesrichTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MessagesrichTB.Size = new System.Drawing.Size(470, 40);
            this.MessagesrichTB.TabIndex = 1;
            this.MessagesrichTB.Text = "";
            // 
            // MessageslistBox
            // 
            this.MessageslistBox.BackColor = System.Drawing.Color.MintCream;
            this.MessageslistBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageslistBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MessageslistBox.FormattingEnabled = true;
            this.MessageslistBox.ItemHeight = 16;
            this.MessageslistBox.Location = new System.Drawing.Point(0, 0);
            this.MessageslistBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MessageslistBox.Name = "MessageslistBox";
            this.MessageslistBox.Size = new System.Drawing.Size(531, 290);
            this.MessageslistBox.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.CancelButton = this.closing_button;
            this.ClientSize = new System.Drawing.Size(726, 402);
            this.Controls.Add(this.ContactsContainer);
            this.Controls.Add(this.closing_button);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ContactsContainer.Panel1.ResumeLayout(false);
            this.ContactsContainer.Panel1.PerformLayout();
            this.ContactsContainer.Panel2.ResumeLayout(false);
            this.ContactsContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsContainer)).EndInit();
            this.ContactsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label auth_label;
        private System.Windows.Forms.Button closing_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer ContactsContainer;
        public System.Windows.Forms.ListBox ContactslistBox;
        private System.Windows.Forms.ListBox MessageslistBox;
        private System.Windows.Forms.RichTextBox MessagesrichTB;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button new_contact_button;
        private System.Windows.Forms.Label user_name_label;
    }
}