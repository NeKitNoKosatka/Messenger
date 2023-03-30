using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsClient
{
    class Protection
    {
        // алфавит, символы которого можно использовать при шифровании (английский, русский в обоих регистрах, цифры и знаки)
        private readonly char[] characters = "1234567890!@#$%^&*()_+-=\\№;:?/.,''<>|{}[]\"АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯйцуке`нгшщзхъфывапролджэячсмитьбю ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToArray();

        private readonly Generator generator = new Generator(); // инициализация генератора случайных чисел

        // возвращает ключи шифрования
        public long[] GenerateKeys()
        {
            // генерация двух взаимно простых чисел, для создания ключей шифрования, с использованием генератора простых чисел
            long p = generator.GenerateNumberForKey()[0]; 
            long q = generator.GenerateNumberForKey()[1];

            // создание ключей шифрования
            long n = p * q;
            long m = (p - 1) * (q - 1);
            long d = Calculate_d(m); // закрытый ключ
            long e_ = Calculate_e(d, m); // открытый ключ

            long[] keys = new long[3] { e_, n, d};

            return keys; //[e, n, d]
        }        

        // производит RSA шифрование, возвращает список зашифрованных символов
        // принимает строку, которую необходимо зашифровать и открытые ключи
        private List<string> RSA_Endoce(string s, long e, long n)
        {
            List<string> result = new List<string>();

            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(characters, s[i]);

                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                result.Add(bi.ToString());
            }

            return result;
        }

        // производит RSA дешифрование, возвращает строку с расшифрованным сообщением
        // принимает список зашифрованных символов и закрытые ключи
        private string RSA_Dedoce(List<string> input, long d, long n)
        {
            string result = "";

            BigInteger bi;

            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                int index = Convert.ToInt32(bi.ToString());

                result += characters[index].ToString();
            }

            return result;
        }

        // зашифровать
        public List<string> Protect(string text, long Key_e, long Key_n)
        {
            List<string> result = RSA_Endoce(text, Key_e, Key_n); //keys[0] == e_, keys[1] == n

            return result;
        }

        // расшифровать
        public string Unprotect(List<string> text, long Key_d, long Key_n)
        {

            string result = RSA_Dedoce(text, Key_d, Key_n); //keys[2] == d, keys[1] == n

            return result;

        }

        //вычисление параметра d. d должно быть взаимно простым с m
        private long Calculate_d(long m)
        {
            long d = m - 1;

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0)) //если имеют общие делители
                {
                    d--;
                    i = 1;
                }

            return d;
        }

        //вычисление параметра e
        private long Calculate_e(long d, long m)
        {
            long e = 10;

            while (true)
            {
                if ((e * d) % m == 1 && e != d)
                    break;
                else
                    e++;
            }

            return e;
        }

        public string ToString(List<string> msg1)
        {
            string msg1_str = "";
            foreach (string item in msg1)
                msg1_str += item + " ";

            return msg1_str.TrimEnd();
        }

        public string[] ToStringList(string msg1_str)
        {
            List<string> msg1_array = new List<string>();
            string[] msg1_split = msg1_str.Split();
            foreach (string item in msg1_split)
                msg1_array.Add(item);
            return msg1_split;
        }
    }
}
