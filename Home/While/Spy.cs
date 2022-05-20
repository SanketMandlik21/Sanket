using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.While
{
    internal class Spy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int digit = 0;
            int sum = 0;
            int num=Convert.ToInt32(Console.ReadLine());
            int org = num;
            int prod = 1;

            while (num > 0)
            {
                digit = num % 10;
                sum=sum+ digit;
                prod = prod * digit;
                num = num/10;

            }
            if (sum == prod)
                Console.WriteLine("The number spy" + org);
            else
                Console.WriteLine("The number not spy" + org);

        }
    }
}
