using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int Fact = 1;
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<=num; i++)
            {
                Fact = Fact * i;
            }
            Console.WriteLine("Factorial="+Fact);
        }
    }
}
