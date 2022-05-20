using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Fact
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Accept Number");
            int c=0;
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    Console.WriteLine(i);
                c++;
            }
            Console.WriteLine("count="+c);
        }
    }
}
