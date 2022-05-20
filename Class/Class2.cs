using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int Num1, Num2;
            Console.WriteLine("Enter Number 1");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            Num2 = Convert.ToInt32(Console.ReadLine());

            int Add = Num1 + Num2;
            Console.WriteLine(Add);
        }
    }
}
