using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.While
{
    internal class Factred
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Emter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("Red=" + i);
                else
                    Console.WriteLine("Black=" + i);
            }

        }
    }
}
