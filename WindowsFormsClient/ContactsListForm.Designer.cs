
namespace WindowsFormsClient
{
    partial class ContactsListForm
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
            this.ContactslistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closing_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContactslistBox
            // 
            this.ContactslistBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContactslistBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactslistBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ContactslistBox.FormattingEnabled = true;
            this.ContactslistBox.ItemHeight = 16;
            this.ContactslistBox.Location = new System.Drawing.Point(0, 29);
            this.ContactslistBox.Margin = new System.Windows.Forms.Padding(1);
            this.ContactslistBox.Name = "ContactslistBox";
            this.ContactslistBox.Size = new System.Drawing.Size(372, 336);
            this.ContactslistBox.TabIndex = 0;
            this.ContactslistBox.SelectedIndexChanged += new System.EventHandler(this.ContactslistBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Новый контакт";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
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
            this.closing_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closing_button.Location = new System.Drawing.Point(336, 0);
            this.closing_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closing_button.Name = "closing_button";
            this.closing_button.Size = new System.Drawing.Size(36, 26);
            this.closing_button.TabIndex = 14;
            this.closing_button.Text = "X";
            this.closing_button.UseVisualStyleBackColor = false;
            this.closing_button.Click += new System.EventHandler(this.closing_button_Click);
            // 
            // ContactsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 365);
            this.Controls.Add(this.closing_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContactslistBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ContactsListForm";
            this.Text = "ContactsListForm";
            this.Load += new System.EventHandler(this.ContactsListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ContactslistBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closing_button;
    }
}