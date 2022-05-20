using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            double N1,N2,N3,N4,N5;
            Console.WriteLine("Enter Subject Name 1");
            string ? Name1=Console.ReadLine();
            Console.WriteLine("Mark 1");
            N1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Subject Name 2");
            string ? Name2 = Console.ReadLine();
            Console.WriteLine("Mark 2");
            N2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Subject Name 3");
            string ? Name3 = Console.ReadLine();
            Console.WriteLine("Mark 3");
            N3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Subject Name 4");
            string? Name4 = Console.ReadLine();
            Console.WriteLine("Mark 4");
            N4= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Subject Name 5");
            string ? Name5 = Console.ReadLine();
            Console.WriteLine("Mark 5");
            N5= Convert.ToDouble(Console.ReadLine());
            
            double Avrage=(N1+N2+N3+N4+N5)/5;
            Console.WriteLine(Avrage);








        }
    }
}
