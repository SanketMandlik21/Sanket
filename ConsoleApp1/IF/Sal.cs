using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.IF
{
    internal class Sal
    {
        static void Main(string[] args)
        {
            double basic, gross, da, hra;
            Console.WriteLine("Enter the Employee basic");
            basic =Convert.ToDouble(Console.ReadLine());
            if (basic <= 10000)
            {
                da = basic * 0.8;
                hra = basic * 0.2;
            }
            else if (basic <= 20000)
            {
                da = basic * 0.9;
                hra = basic * 0.25;
            }
            else
            {
                da = basic * 0.95;
                hra = basic * 0.3;
            }
            gross = basic + hra + da;
            Console.WriteLine("Gross Salry "+gross);

        }
    }
}
