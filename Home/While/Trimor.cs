using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.While
{
    internal class Trimor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enetr The Number");
            int num=Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            int cub = num * num * num;
            while (num != 0)
            {
                if (num % 10 != cub % 10)
                {
                    flag = 1;
                    break;

                }
                num = num / 10;
                cub = cub / 10;
            }
            if (flag == 0)
                Console.WriteLine("It is a Trimorphic Number.");
            else
                Console.WriteLine("Tt is a not Trimorphic Number.");
            
        }
    }
}
