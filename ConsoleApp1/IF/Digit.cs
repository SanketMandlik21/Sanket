using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.IF
{
    internal class Digit
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter The Number");
            num=Convert.ToInt32(Console.ReadLine());
            if (num > 99 && num < 1000)
                Console.WriteLine("The Number Are Three Digit");
            else
                Console.WriteLine("The Number Are Not Three Digit");
        }
    }
}
