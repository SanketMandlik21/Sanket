using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Swicth
{
    internal class Area
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Enter the Choice");
            choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    double side, area;
                    Console.WriteLine("Enter side ");
                    side=Convert.ToDouble(Console.ReadLine());
                    area=Convert.ToDouble(Console.ReadLine());
                    area = side * side;
                    Console.WriteLine("Area Square"+area);
                    break;
                
                case 2:
                    double radius, circal;
                    Console.WriteLine("Enter redius");
                    radius=Convert.ToDouble(Console.ReadLine());
                    circal=Convert.ToDouble(Console.ReadLine());
                    circal = 2 * 3.14 * radius * radius;
                    Console.WriteLine("Area Of Circal" +circal);
                    break;

                case 3:
                    double len, bre,rectangle;
                    Console.WriteLine("Enter Len");
                    len=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter bre");
                    bre = Convert.ToDouble(Console.ReadLine());
                    rectangle = len * bre;
                    Console.WriteLine("Area Of Rectangle"+rectangle);
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }


        }
    }
}
