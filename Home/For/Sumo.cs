using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.For
{
    internal class Sumo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i=1;i<=num;i=i+2)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum Odd ="+sum);
        }
    }

    class Neow
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sq = num * num;
            int Sum = 0;
            while (sq > 0)
            { 
                int d=sq%10;
                Sum =Sum+d;
                sq = sq/10;

            }
            Console.WriteLine("Sumo=" + sq);

        }
    }
}

