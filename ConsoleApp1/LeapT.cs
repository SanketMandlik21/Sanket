using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class LeapT
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the Year");
            year=Convert.ToInt32(Console.ReadLine());
            string y;
            Console.WriteLine(year % 4 == 0 ?"Leap":"Not Leap");
           

            
        }
    }
}
