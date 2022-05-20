using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.While
{
    internal class Twins
    {
        static void Main(string[] args)
        {
            int x=0;
            Console.WriteLine("Enter The Number One");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Number Two");
            int num2=Convert.ToInt32(Console.ReadLine());
           
            for (int i = 1; i <= num1; i++)
            {
                if (num1 % i == 0)
                    x++;
                  
            }
            int y = 0;
            for (int i = 1; i <= num2; i++)
            { 
                if(num2%i==0)
                    y++;
            }
            if(x==0 && y==0)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not Prime");

           
        }
    }
}
