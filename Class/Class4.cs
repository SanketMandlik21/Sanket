using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            double Area, Side,Perimeter;
            Console.WriteLine("Enter the Side");
            Side =Convert.ToDouble(Console.ReadLine());
            Area = Side* Side;
            Perimeter = 4 * Side;
            Console.WriteLine(Perimeter);   
            Console.WriteLine(Area);
        }
    }
}
