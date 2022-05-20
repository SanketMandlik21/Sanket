using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.For
{
    internal class Amastrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a=Convert.ToInt32(Console.ReadLine());
            int b = a;
            int Sum = 0;
            while(a>0)
            {
                int digit=a%10;
                Sum = Sum + digit + digit + digit;
                a = a / 10;
            }
            Console.WriteLine("Amastrong="+a);

        }
    }
}
