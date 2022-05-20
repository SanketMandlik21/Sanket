using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Swicth
{
    internal class Days
    {
        static void Main(string[] args)
        {
            int Day;
            Console.WriteLine("Enter Day Number");
             Day=Convert.ToInt32(Console.ReadLine());
            switch (Day)
            {
                case 1: Console.WriteLine("Monday");
                    break;

                case 2: Console.WriteLine("Tuesday");
                    break;

                case 3: Console.WriteLine("Wednesday");
                    break;

                case 4: Console.WriteLine("Thurday");
                    break;

                case 5: Console.WriteLine("Friday");
                    break;

                case 6: Console.WriteLine("Saturday");
                    break;

                case 7: Console.WriteLine("Sunday");
                    break;

                 default: Console.WriteLine("Not Days Present This Number");
                    break;



            }
        }
    }
}
