using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            double Amount, Price, Discount,Quantity,Net;
            Console.WriteLine("Enter the Quantity");
            Quantity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price");
            Price = Convert.ToDouble(Console.ReadLine());

            Amount = Price * Quantity;
            Discount = Amount * 20 / 100;
            Console.WriteLine(Discount);
            Net = Amount - Discount;
            Console.WriteLine(Net);
        }
    }
}
