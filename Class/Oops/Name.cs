using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Oops
{
    internal class Name
    {
        public void M1()
        {
            Console.WriteLine("M1");
            M2();
        }
        public void M2()
        {
            Console.WriteLine("M2");
        }
        public static void M3()
        {
            Console.WriteLine("M3");
        }
        public static void M4()
        {
            Console.WriteLine("M4");
        }

    
    
        static void Main(string[] args)
        {
            Name name = new Name();
            name.M1();
            Name.M3();
        }
    }
}
