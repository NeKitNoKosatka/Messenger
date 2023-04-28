﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //transpTLP.Location = new Point(0, 0);
            ////transpTLP.Parent = MessageslistBox;
            //transpTLP.Dock = DockStyle.Bottom;
            ////transpTLP.Anchor = AnchorStyles.Bottom;
            //transpTLP.AutoSize = true;
            //transpTLP.MaximumSize = new Size(0, 100);

            //transpTLP.ColumnStyles.Add(new ColumnStyle());
            //transpTLP.ColumnStyles.Add(new ColumnStyle());
            //transpTLP.Controls.Add(richTextBox2);

            tableLayoutPanel7.Controls.Add(richTextBox2, 1, 0);
            tableLayoutPanel7.AutoSize = true;



            //Paint += new PaintEventHandler(info_panel_Paint);//перерисовываем messageBox

            //tableLayoutPanel7.BackColor = Color.Red;
            //this.TransparencyKey = Color.Red;

            //Paint += new PaintEventHandler(info_panel_Paint);//перерисовываем infoPanel
        }

        public class TranspTLP : TableLayoutPanel           //ExtendedPanel : Panel
        {
            private const int WS_EX_TRANSPARENT = 0x20;
            public TranspTLP()
            {
                SetStyle(ControlStyles.Opaque, true);
            }

            private int opacity = 0;
            [DefaultValue(50)]
            public int Opacity
            {
                get
                {
                    return this.opacity;
                }
                set
                {
                    if (value < 0 || value > 100)
                        throw new ArgumentException("value must be between 0 and 100");
                    this.opacity = value;
                }
            }
            protected override CreateParams CreateParams
            {
                get
                {
                    CreateParams cp = base.CreateParams;
                    cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;
                    return cp;
                }
            }
            protected override void OnPaint(PaintEventArgs e)
            {
                using (var brush = new SolidBrush(Color.FromArgb(this.opacity * 255 / 100, Color.Black)))  //this.BackColor
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }                
                base.OnPaint(e);
            }


        }



        //class TranspTLP : TableLayoutPanel

        //{

        //    protected override CreateParams CreateParams

        //    {

        //        get

        //        {

        //            CreateParams cp = base.CreateParams;

        //            cp.ExStyle |= 0x00000020; //This returns the transparent (no background painting) mode

        //            return cp;

        //        }

        //    }

        //}

        //[Flags]
        //enum AnimateWindowFlags
        //{
        //    AW_HOR_POSITIVE = 0x00000001,
        //    AW_HOR_NEGATIVE = 0x00000002,
        //    AW_VER_POSITIVE = 0x00000004,
        //    AW_VER_NEGATIVE = 0x00000008,
        //    AW_CENTER = 0x00000010,
        //    AW_HIDE = 0x00010000,
        //    AW_ACTIVATE = 0x00020000,
        //    AW_SLIDE = 0x00040000,
        //    AW_BLEND = 0x00080000
        //}
        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);



        private void Form1_Load(object sender, EventArgs e)
        {
            //AnimateWindow(this.Handle, 1000,
            //AnimateWindowFlags.AW_BLEND |
            
            //AnimateWindowFlags.AW_CENTER);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
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
            ContactslistBox.Items.Add("    " + "Name SecondName");
            MessageslistBox.Items.Add("очень длинное сообщенеие, которое не поместится в боксе, оно, правда, очень длинное, и места под него совсем нет. В этом можно не сомневаться. и ещё раз.очень длинное сообщенеие, которое не поместится в боксе, оно, правда, очень длинное, и места под него совсем нет. В этом можно не сомневаться");
            MessageslistBox.Items.Add("system");
            MessageslistBox.Items.Add(" ");


            //MessageslistBox.Update();
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

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
            ((RichTextBox)sender).Location = new Point(((RichTextBox)sender).Location.X, ((RichTextBox)sender).Location.Y - 16);

        }

        private void richTextBox1_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
            ((RichTextBox)sender).Location = new Point(((RichTextBox)sender).Location.X, ((RichTextBox)sender).Location.Y - 5);
        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {
            
        }
        

        private void richTextBox2_SizeChanged(object sender, EventArgs e)
        {
            //MessageslistBox.Items.Add("拐杖");
            //MessageslistBox.Items.Remove("拐杖");
            //Paint += new PaintEventHandler(transpTLP_Paint);
            //MessageslistBox.Refresh();
            //this.Refresh();
            //transpTLP.Refresh();
        }
    }
}
