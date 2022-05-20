using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.For
{
    internal class GCD
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter One Number");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Two Number");
            int b=Convert.ToInt32(Console.ReadLine());
            int gcd = 1;
            for (int i = 2; i <= a && i <= b; i++)
            {
                if (a % i == 0 && b % i == 0)
                { 
                    gcd= i;
                }
                Console.WriteLine("GCD"+gcd);
            }
        }
    }
}
