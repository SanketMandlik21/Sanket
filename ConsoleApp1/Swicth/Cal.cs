using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Swicth
{
    internal class Cal
    {
        static void Main(string[] args)
        {
            int num1,num2;
            string operand;
            double ans;
            Console.WriteLine("Enter the Number 1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Operand");
            operand=Console.ReadLine();
            Console.WriteLine("Enter the Number 2");
            num2=Convert.ToInt32(Console.ReadLine());
            switch (operand)
            {
                case "-": ans = num1 - num2;
                    break;
                   
                case "+": ans = num2 - num1;
                    break;

                case "*": ans = num1 * num2;
                    break;

                case "/":ans = num1 / num2;
                    break;
                    
                default:ans = 0;
                    break;

            }
            Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + ans.ToString());
            Console.ReadLine();

        }
    }
}
