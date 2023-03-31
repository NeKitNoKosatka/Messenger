using System;

namespace test
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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

    class Program
    {
        static void Main(string[] args)
        {

            //char[] letters = Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).ToArray();
            //char[] letters = "#!@$%^&*()_-=+~/№;:[]{},.<>|?АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ 1234567890абвгдеёжзийклмнопрстуфхцчшщъыьэюяABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToArray();
            //string x = "x";
            //Console.WriteLine(x);
            //x = x + "y";
            //Console.WriteLine(x);
            //test.Generator Gn = new test.Generator();
            //Console.WriteLine("result: " + Gn.GenerateNumberForKey()[0].ToString() + " " + Gn.GenerateNumberForKey()[1].ToString());
            //Console.WriteLine(letters[20]);

            int intCatcher;

            int.TryParse(string.Join("", "abc1as2ff dd2 m2n".Where(c => char.IsDigit(c))), out intCatcher);

            Console.WriteLine(intCatcher);
            
            int.TryParse(string.Join("", "abcasff".Where(c => char.IsDigit(c))), out intCatcher);

            Console.WriteLine(intCatcher);

        }
    }
}
