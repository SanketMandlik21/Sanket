using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.For
{
    internal class Given
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int Num=Convert.ToInt32(Console.ReadLine());
            int i;
            for ( i = 1; i<=10; i++)
            {
                Console.WriteLine(Num*i );
            }

        }
    }
}
