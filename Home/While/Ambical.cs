using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.While
{
    internal class Ambical
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number One ");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Number Two");
            int num2=Convert.ToInt32(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i <= num1; i++)
            {
                if (num1 % i == 0)
                    sum1 = sum1 + i;
            }
            for (int j=1; j<= num2; j++)
            {
                if (num2 % j == 0)
                    sum2 = sum2 + j;
            }
            if (sum1 == sum2)
                Console.WriteLine("These numbers are amicable");
            else
                Console.WriteLine("These numbers are not amicable");


        }
    }
}
