using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Pattern
{
    internal class Star
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number ro");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number col");
            int b = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=a;i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    Console.Write("@");
                }
                Console.WriteLine();
            }
        }
    }
}
