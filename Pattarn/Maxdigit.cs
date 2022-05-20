using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattarn
{
    class Maxdigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the frist number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            int num3=Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Number one Max");
                }
                else
                {
                    Console.WriteLine("Number Three Max");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Number Two Max");
            }
            else 
            {
                Console.WriteLine("Number Three Max");
            }
        }
    }
    
    class Maxnum
    {
        static void Main(string[] args)
        {
            int larg = 0;
            int num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            while(num!=0)
            {
                  larg = num% 10;
                num = num / 10;
            }
            Console.WriteLine("large"+larg);

        }
    }
}
