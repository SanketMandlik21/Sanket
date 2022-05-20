using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception1
{
    class Sam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Start");
            try
            {
                int a=int.Parse(Console.ReadLine());
                int b=int.Parse(Console.ReadLine());    
                Console.WriteLine("Divisible ="+a/b);
                Console.WriteLine("Try Error");
            }
            catch (DivideByZeroException obj)
            {
                Console.WriteLine("Divisble Zero");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }
        }
    }

    class Mobile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mobile No");
            long a = long.Parse(Console.ReadLine());
            int Cont = 0;
            while(a>0)
            {
                a++;
                a = a / 10;

            }
            try
            {
                if (a == 10)
                {
                    Console.WriteLine("No is Valid");
                }
                else
                    throw new ApplicationException();
            }
            catch(Exception ex)
            {
                Console.WriteLine("No Not  Valid");
            }
        }
    }
    class Nullr
    {
        static void Main(string[] args)
        {
                
        }
    }

}
