using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Prime_for
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number ");
            int num= Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (int i = 0; i <= num; i++)
            {
                if (num % i == 0)
                {
                   flag =1;
                }
                
            }
            Console.Read();

        }
    }
}
