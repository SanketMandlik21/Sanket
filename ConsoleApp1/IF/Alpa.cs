using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.IF
{
    internal class Alpa
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter Character");
            ch = Convert.ToChar(Console.Read());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("Alpabhet");
            }
            else if (ch >= 0 || ch <= 9)
            {
                Console.WriteLine("Digits");
            }
            else
            {
                Console.WriteLine("Special Character");
            }
        }
    }
}
