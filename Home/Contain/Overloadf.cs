using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Contain
{
    internal class Over
    {
     
        public void voulume(double r)
        {
            double Sq= 2 * 3.14 * r * r;
            Console.WriteLine("Squrer ="+Sq);
           
        }
        public void voulume(double h,double r)
        {
            double C= h * r;
            Console.WriteLine("Cylinder ="+C);
           
        }
        public  void voulume(double l,double b,double h)
        {
            double Cu=l * b * h;
            Console.WriteLine("Cuboid =" + Cu);
            
        }
    }
    class Otest
    {
        static void Main(string[] args)
        {
            Over ov = new Over();
            ov.voulume(10);
            ov.voulume(50, 50);
            ov.voulume(55, 44, 45);

        }
    }
}
