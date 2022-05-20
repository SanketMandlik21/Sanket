using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception1
{
    class Delec
    {
        public static void fact(int a)
        {
            int fact = 1;
            for (int i = 0; i <= a; i++)
                fact = fact * i;
            Console.WriteLine("Factorial =" + fact);

        }
        public delegate void mydelegate(int a);
        static void Main(string[] args)
        {
            mydelegate f = fact;
            f(60);
        }

    }

    class Da
    {
        public delegate void mydelegate(int a,int b);


        public void add(int a, int b)
        {
            Console.WriteLine("Sum ="+(a+b));
        }
        public void Prod(int a,int b)
        {
            Console.WriteLine("Prod ="+(a*b));
        }
        static void Main(string[] args)
        {
            Da d = new Da();
            mydelegate c = d.Prod;
            c += d.add;
            c(4,5);
        }
        
    }

    class Dire
    {
        public int Add(int a,int b)
        {
            int c = a + b;
            return c;
        }
        public int Sub(int x,int y)
        {
            int z=x + y;    
            return z;
        }

        static void Main(string[] args)
        {
         

        }
    }

}
