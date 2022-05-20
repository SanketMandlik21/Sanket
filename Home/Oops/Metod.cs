using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Oops
{
    internal class Metod
    {
        static public void area(int a)
        {
            Console.WriteLine("circle "+2*3.14*a*a);
        }
        static public void area(float x,float y)
        {
            Console.WriteLine("Rectangle"+x*y);
        }
        static public void area(double s)
        {
            Console.WriteLine("Square"+s*s);
        }
        static void Main(string[] args)
        {
            Metod.area(4);
            Metod.area(5.5f,4.5f);
            Metod.area(5);

        }
    }
}
