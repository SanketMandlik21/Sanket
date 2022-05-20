using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.IF
{
    internal class Max
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter Number 1");
            num1 = Convert.ToInt32(args[0]);
            Console.WriteLine("Enter Number 2");
            num2 = Convert.ToInt32(args[1]);
            Console.WriteLine("Enter Number 3");
            num3 = Convert.ToInt32(args[2]);
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Number One are Largest ");
                }
                else
                {
                    Console.WriteLine("Number Three are Largest");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Number Two are Largest");

            }
            else
            {
                Console.WriteLine("Number Three Are Largest");

            }

        }
      }
}
