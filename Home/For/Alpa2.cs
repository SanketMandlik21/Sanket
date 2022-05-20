using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.For
{
    internal class Alpa2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Alpabhet");
            char ch;
            ch = Convert.ToChar(Console.Read());
            
            for(ch='a';ch<='z';ch++)
            {
                Console.WriteLine(ch+"");
            }
        }
    }
}
