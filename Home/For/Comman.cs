using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.For
{
    internal class Comman
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number one");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number Two");
            int num2=Convert.ToInt32(Console.ReadLine());
            int Fact = 0;
            for(int i=1;i<=num1&&i<=num2;i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                    Fact = i;
 

            }
            Console.WriteLine("Factor of Two Number="+Fact);
        }
    }
}
