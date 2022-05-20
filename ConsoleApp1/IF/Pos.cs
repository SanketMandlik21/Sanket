using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.IF
{
    internal class Pos
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter The Number");
            num=Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Number Are Posivtive");
            }
            else if (num < 0)
            {
                Console.WriteLine("Number Are Negitive");
            }
            else 
            {
                Console.WriteLine("Enter Zero");
            }
            
        }
    }
}
