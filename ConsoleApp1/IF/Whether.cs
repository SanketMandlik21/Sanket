
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.IF
{
    internal class Whether
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Number");
            num=Convert.ToInt32(Console.ReadLine());
            if ((num % 5 == 0) && (num % 11 == 0))
                Console.WriteLine("Number  are 5 and 10 divisible ");
            else
                Console.WriteLine("Number are 5 and 10 not divisibe ");
        }
    }
}
