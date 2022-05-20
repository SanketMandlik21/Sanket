using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Swicth
{
    internal class Number
    {
        static void Main(string[] args)
        {
            int number;
            number= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The word");
            switch (number)
            {
                case 1: Console.WriteLine("Sanket");
                    break;

                case 2: Console.WriteLine("Ashish");
                    break ;

                case 3: Console.WriteLine("Shubham");
                    break;

                case 4: Console.WriteLine("Chaitayan");
                    break;

                case 5: Console.WriteLine("Rushikesh");
                    break;
                default: Console.WriteLine("Input Number 1 to 5 Not Valid");
                    break;
            }
        }
    }
}
