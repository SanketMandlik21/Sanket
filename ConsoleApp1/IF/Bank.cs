using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bank
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Charcter");
            char ch = Convert.ToChar(Console.Read());
            if (ch >= 65 && ch <= 90)
            {
                ch = (char)(ch + 32);
                
            }
            else if (ch >= 97 && ch <= 122)
            {
                ch = (char)(ch - 32);
                
            }
            Console.WriteLine(ch);
            
        }
    }
}
