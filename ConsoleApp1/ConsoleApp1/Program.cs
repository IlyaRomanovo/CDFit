using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "qwERty";
            //s = s.ToLower();
            //char r = ';';
            //int g = s.Length;
            //Console.WriteLine(s);
            //Console.WriteLine(Char.IsLetter(s[2]));

            string s = "PAnamamanaPwersd";
            s = s.ToLower();
            string s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    s1 += s[i];
                }
            }

            bool q = true;

            if (s1.Length % 2 == 0)
            {
                for (int i = 0; i < s1.Length / 2; i++)
                {
                    if (s1[i] != s1[s1.Length - 1 - i])
                    {
                        q = false;
                        break;
                    }
                }

                Console.WriteLine(q);
            }


            if (s1.Length % 2 != 0)
            {
                for (int i = 0; i < s1.Length / 2; i++)
                {
                    if (s1[i] != s1[s1.Length - 1 - i])
                    {
                        q = false;
                        break;
                    }
                }

                Console.WriteLine(q);
            }

            Console.WriteLine(s1);
        }
    }
}
