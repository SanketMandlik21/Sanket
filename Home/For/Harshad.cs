using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.For
{
    internal class Harshad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int sum = 0;
            int num = Convert.ToInt32(Console.ReadLine());
            int temp=num ;
            
            while (temp>0)
            {
                sum = sum + temp % 10;
                temp = temp / 10;
            }
            int res = num % sum;
            if (res == 0)
                Console.WriteLine("Har num");
            else
                Console.WriteLine("Not Num");
        }

        
    }
}
