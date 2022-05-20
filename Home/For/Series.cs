using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.For
{
    internal class Series
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int nu1 = 0;
            int nu2 = 1;
            int nu3;
            nu3=Convert.ToInt32(Console.ReadLine());
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < num; ++i)
            {
                nu3 = nu1 + nu2;
                Console.WriteLine(nu3);
                nu1 = nu2;
                nu2 = nu3;
               
            }

        }
    }
}
