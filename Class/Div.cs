using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Div
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Divisible");
            int num =Convert.ToInt32(Console.ReadLine());
            if(num%7==0 || num%10==7)
                Console.WriteLine("Number are Buzz");
            else
                Console.WriteLine("Number are  Not Buzz");
        }
    }
}
