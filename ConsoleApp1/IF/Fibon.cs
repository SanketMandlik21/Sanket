using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.IF
{
    internal class Fibon
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
	        int temp = a + b;
            a=b;
	        b=temp;
	
            }
            Console.WriteLine(a);
        }
    }
}
