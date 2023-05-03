using System;



    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    namespace test
    {
        class Generator
        {
            private readonly Random rnd = new Random();
            public int[] GenerateNumberForKey()
            {
                int n, m;

                m = 0;
                n = 0;

                while (!(IsPrime(m) && IsPrime(n))) 
                {
                    if (!IsPrime(m))
                    {
                        m = rnd.Next(1, 150);
                        
                    }
                    else if (!IsPrime(n))
                    {
                        n = rnd.Next(150, 300);
                        
                    }
                }



                int[] numbers = new int[2] { m, n };

                return numbers;
            }


            private bool IsPrime(int x)
            {
                if (x < 2) return false;
                for (int i = 2; i * i <= x; i++)
                    if ((x % i) == 0) return false;
                return true;
            }

            private int FindNOD(int m, int n)
            {
                while (m != n)
                {
                    if (m > n)
                    {
                        m -= n;
                    }
                    else
                    {
                        n -= m;
                    }
                }

                int nod = n;
                return nod;
            }
        }
    }



//transpTLP.Location = new Point(0, 0);
////transpTLP.Parent = MessageslistBox;
//transpTLP.Dock = DockStyle.Bottom;
////transpTLP.Anchor = AnchorStyles.Bottom;
//transpTLP.AutoSize = true;
//transpTLP.MaximumSize = new Size(0, 100);

//transpTLP.ColumnStyles.Add(new ColumnStyle());
//transpTLP.ColumnStyles.Add(new ColumnStyle());
//transpTLP.Controls.Add(richTextBox2);





//Paint += new PaintEventHandler(info_panel_Paint);//перерисовываем messageBox

//tableLayoutPanel7.BackColor = Color.Red;
//this.TransparencyKey = Color.Red;

//Paint += new PaintEventHandler(info_panel_Paint);//перерисовываем infoPanel


//public class TranspTLP : TableLayoutPanel           //ExtendedPanel : Panel
//{
//    private const int WS_EX_TRANSPARENT = 0x20;
//    public TranspTLP()
//    {
//        SetStyle(ControlStyles.Opaque, true);
//    }

//    private int opacity = 0;
//    [DefaultValue(50)]
//    public int Opacity
//    {
//        get
//        {
//            return this.opacity;
//        }
//        set
//        {
//            if (value < 0 || value > 100)
//                throw new ArgumentException("value must be between 0 and 100");
//            this.opacity = value;
//        }
//    }
//    protected override CreateParams CreateParams
//    {
//        get
//        {
//            CreateParams cp = base.CreateParams;
//            cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;
//            return cp;
//        }
//    }
//    protected override void OnPaint(PaintEventArgs e)
//    {
//        using (var brush = new SolidBrush(Color.FromArgb(this.opacity * 255 / 100, Color.Black)))  //this.BackColor
//        {
//            e.Graphics.FillRectangle(brush, this.ClientRectangle);
//        }                
//        base.OnPaint(e);
//    }


//}



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



class Program
{

    public int PhoneLength { get; set; }
    public string Region = "RU";
    public string PhoneMask(string Phone)
    {
        var newVal = Regex.Replace(Phone, @"[^0-9]", "");
        if (PhoneLength != newVal.Length && !string.IsNullOrEmpty(newVal))
        {
            PhoneLength = newVal.Length;
            Phone = string.Empty;
            if (Region == "BY")
            {
                if (newVal.Length <= 3)
                {
                    Phone = Regex.Replace(newVal, @"(\d{3})", "+$1");
                }
                else if (newVal.Length <= 5)
                {
                    Phone = Regex.Replace(newVal, @"(\d{3})(\d{0,2})", "+$1($2)");
                }
                else if (newVal.Length <= 8)
                {
                    Phone = Regex.Replace(newVal, @"(\d{3})(\d{2})(\d{0,3})", "+$1($2)$3");
                }
                else if (newVal.Length <= 10)
                {
                    Phone = Regex.Replace(newVal, @"(\d{3})(\d{2})(\d{0,3})(\d{0,2})", "+$1($2)$3-$4");
                }
                else if (newVal.Length > 10)
                {
                    Phone = Regex.Replace(newVal, @"(\d{3})(\d{2})(\d{0,3})(\d{0,2})(\d{0,2})", "+$1($2)$3-$4-$5");
                }
            }
            else if (Region == "RU")
            {
                if (newVal.Length <= 1)
                {
                    Phone = Regex.Replace(newVal, @"(\d{1})", "+$1");
                }
                else if (newVal.Length <= 4)
                {
                    Phone = Regex.Replace(newVal, @"(\d{1})(\d{0,3})", "+$1($2)");
                }
                else if (newVal.Length <= 7)
                {
                    Phone = Regex.Replace(newVal, @"(\d{1})(\d{3})(\d{0,3})", "+$1($2)$3");
                }
                else if (newVal.Length <= 9)
                {
                    Phone = Regex.Replace(newVal, @"(\d{1})(\d{3})(\d{0,3})(\d{0,2})", "+$1($2)$3-$4");
                }
                else if (newVal.Length > 9)
                {
                    
                    Phone = Regex.Replace(newVal, @"(\d{1})(\d{3})(\d{0,3})(\d{0,2})(\d{0,2})", "8 ($2) $3-$4-$5");
                }
                
            }
        }
        return Phone;
    }

    bool isValid(string email)
    {
        string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
        Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
        return isMatch.Success;
    }

    static void Main(string[] args)
        {
        Program program = new Program();
        string email = "q@1111111.ru";

        var res = program.isValid(email);

        Console.WriteLine(email);
        Console.WriteLine(res);



            //char[] letters = Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).ToArray();
            //char[] letters = "#!@$%^&*()_-=+~/№;:[]{},.<>|?АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ 1234567890абвгдеёжзийклмнопрстуфхцчшщъыьэюяABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToArray();
            //string x = "x";
            //Console.WriteLine(x);
            //x = x + "y";
            //Console.WriteLine(x);
            //test.Generator Gn = new test.Generator();
            //Console.WriteLine("result: " + Gn.GenerateNumberForKey()[0].ToString() + " " + Gn.GenerateNumberForKey()[1].ToString());
            //Console.WriteLine(letters[20]);

            //int intCatcher;

            //int.TryParse(string.Join("", "abc1as2ff dd2 m2n".Where(c => char.IsDigit(c))), out intCatcher);

            //Console.WriteLine(intCatcher);

            //int.TryParse(string.Join("", "abcasff".Where(c => char.IsDigit(c))), out intCatcher);

            //Console.WriteLine(intCatcher);

        }
}

