using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Oops
{
    internal class Calsi
    {
        public int add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Addition ");
            return sum;
        }
        public void leap(int year)
        {
            if (year % 4 == 0)
                Console.WriteLine("Leap" + year);
            else
                Console.WriteLine("Not Leap" + year);
        }
        public float SI(int A, int B, int C)
        {
            float SI = (A + B + C) / 100;
            Console.WriteLine("Simple Interset");
            return SI;
        }
    }
    class CalD
    {
        static void Main(string[] args)
        {
            Calsi calsi = new Calsi();
            int sum = calsi.add(10, 20);
            Console.WriteLine(sum);
            calsi.leap(2014);
            float SI = calsi.SI(100, 50, 30);
            Console.WriteLine(SI);
        }
    }
    
}
