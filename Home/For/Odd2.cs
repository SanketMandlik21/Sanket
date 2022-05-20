using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.For
{
    internal class Odd2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The number");
            int num = 521;
            for (int i = 229; i <= num; i++)
            {
                if(i%2!=0)
                    Console.WriteLine(i);
            }

        }
    }
    class odd3
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                if(i%2!=0)
                    Console.WriteLine(i);
            }
        }
    }
}
