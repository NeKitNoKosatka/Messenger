using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsClient
{
    class Generator
    {
        private readonly Random rnd = new Random();
        // метод, генерирующий взаимно простые числа для создания ключей шифрования
        public int[] GenerateNumberForKey()
        {
            int n, m;

            m = 0;
            n = 0;

            while (!(IsPrime(m) && IsPrime(n)))
            {
                if (!IsPrime(m))
                {
                    m = rnd.Next(2, 150);

                }
                else if (!IsPrime(n))
                {
                    n = rnd.Next(150, 300);

                }
            }

            int[] numbers = new int[2] { m, n };

            return numbers;
        }

        // метод, проверяющий простое ли число
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

