using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.For
{
    internal class Product
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number  One");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number Two");
            int num2 =Convert.ToInt32(Console.ReadLine());
            int pro = 1;
            int r;
            for(int i=num1;i>0;i=i/10)
            {
                r = i % 10;
                pro = pro * r;
            }
            Console.WriteLine("The Product Digit=" +pro ,+num2);

        }
    }
}
