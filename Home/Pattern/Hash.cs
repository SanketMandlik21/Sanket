using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Pattern
{
    internal class Hash
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Row");
            int r =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Col");
            int c = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= r; i++)
            {
                for (c = 1; c <= 5; c++)
                {
                    if (c%2==0)
                        Console.Write("#");
                    else
                        Console.Write("@");

                }

                Console.WriteLine("");

            }

        }
    }
}
