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
            string s = "()[]{}";
            string round = "()", square = "[]", figure = "{}";

            s = s.Replace(round, "A");
            s = s.Replace(square, "B");
            s = s.Replace(figure, "C");

            Console.WriteLine(s);
        }
    }
}
