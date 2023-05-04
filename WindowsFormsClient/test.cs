using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class test : Form
    {
        bool chek = true;

        Size size_txt;

        public test()
        {
            InitializeComponent();                
            
            
        }

        private void MeasureStringMin(PaintEventArgs e)
        {

            // Set up string.
            string measureString = textBox1.Text;
            Font stringFont = new Font("Arial", 13);

            // Measure string.
            SizeF stringSize = new SizeF();
            stringSize = e.Graphics.MeasureString(measureString, stringFont);

            Console.WriteLine("size: " + stringSize);
            
        }


        private void RegisterEventHandler()
        {
            //text_label.SizeChanged += new EventHandler(this.text_label_SizeChanged);
        }

        private void text_label_SizeChanged(object sender, System.EventArgs e)
        {
            //MessageBox.Show("The size of the 'Button' control has changed. Size: " + size_txt);
        }


        private void create_panel(bool chek, string text)
        {
            Label text_label = new Label();
            Label time_label = new Label();


            text_label.Text = text;
            time_label.Text = "15:42";

            Font stringFont = new Font("Arial", 13);
            text_label.Width = 180;
            text_label.Font = stringFont;
            text_label.Dock = DockStyle.Fill;
            text_label.Padding = new Padding(5);
            text_label.AutoSize = true;
            text_label.AutoEllipsis = true;
            text_label.MaximumSize = new Size(180, 0);
            text_label.MinimumSize = new Size(60, 0);

            Font timestringFont = new Font("Arial", 5);
            time_label.Font = timestringFont;
            time_label.Dock = DockStyle.Bottom;
            time_label.TextAlign = ContentAlignment.MiddleRight;
            


            Panel panel_min = new Panel();
            
            panel_min.AutoSize = true;
            panel_min.MaximumSize = new Size(200, 0);
            

            if (chek)
            {
                panel_min.BackColor = Color.FromArgb(245,245,245);
                panel_min.Anchor = AnchorStyles.Left;

            }
            else
            {
                panel_min.BackColor = Color.FromArgb(202,255,252);
                panel_min.Anchor = AnchorStyles.Right;

            }
          
            panel_min.Parent = tableLayoutPanel1;
            text_label.Parent = panel_min;
            time_label.Parent = panel_min;

            tableLayoutPanel1.ScrollControlIntoView(panel_min);


        }




        private void test_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {   
            //Brush myBrush = Brushes.Black;
            //if (e.Index == -1)
            //    return;

            //// Draw the background of the ListBox control for each item.
            //if (e.Index % 2 == 0)
            //{
            //    e = new DrawItemEventArgs(e.Graphics,
            //                              e.Font,
            //                              e.Bounds,
            //                              e.Index,
            //                              e.State,
            //                              e.ForeColor,
            //                              Color.Gray);


            //    TextRenderer.DrawText(e.Graphics, listBox1.Items[e.Index].ToString(), e.Font,
            //    e.Bounds, e.ForeColor, e.BackColor, TextFormatFlags.Left);

            //    //myBrush = Brushes.Black;
            //    e.Graphics.DrawString(listBox1.Items[e.Index].ToString(),
            //    e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            //}
            //else if (e.Index % 2 != 0)
            //{
            //    e = new DrawItemEventArgs(e.Graphics,
            //                              e.Font,
            //                              e.Bounds,
            //                              e.Index,
            //                              e.State,
            //                              e.ForeColor,
            //                              Color.White);

            //    TextRenderer.DrawText(e.Graphics, listBox1.Items[e.Index].ToString(), e.Font,
            //    e.Bounds, e.ForeColor, e.BackColor, TextFormatFlags.Right);

            //    //myBrush = Brushes.Black;
            //    e.Graphics.DrawString(listBox1.Items[e.Index].ToString(),
            //    e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);


            //}

            //e.DrawBackground();



            //if (e.Index % 2 == 0)
            //{                
            //    //myBrush = Brushes.Black;
            //    e.Graphics.DrawString(listBox1.Items[e.Index].ToString(),
            //    e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            //}
            //else if (e.Index % 2 != 0)
            //{
            //    TextRenderer.DrawText(e.Graphics, listBox1.Items[e.Index].ToString(), e.Font,
            //    e.Bounds, e.ForeColor, e.BackColor, TextFormatFlags.Right);

            //    myBrush = Brushes.White;
            //    e.Graphics.DrawString(listBox1.Items[e.Index].ToString(),
            //    e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            //}                     
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.SelectedIndex = -1;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            label1.Text = text;

            create_panel(chek, text);

            //listBox1.Items.Add("1");
            //if (chek)
            Refresh();

            chek = !chek;
            //Console.WriteLine("idx: " + listBox1.SelectedIndex);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            //// Set up string.
            //string measureString = textBox1.Text;
            //Font stringFont = new Font("Arial", 13);

            //// Measure string.
            //SizeF stringSize = new SizeF();
            //stringSize = e.Graphics.MeasureString(measureString, stringFont);

            //size_txt = stringSize;
            //Console.WriteLine("size: " + stringSize);
        }
    }
}
