using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Pattern
{
    internal class C
    {
        static void Main(string[] args)
        {
            int r = 5;
            int c = 5;
            for (r = 1; r <= 5; r++)
            {
                for (c = 1; c <= 5; c++)
                {
                    if (c == 1 || r == 1 || r == 5)
                        Console.Write("*");

                }

                Console.WriteLine(" ");

            }

        }
    }
}
