using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Addition1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int num; 
            int sum=0;
            num=Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i <= num;++i)
            {
                sum=sum+i;
            }
            Console.WriteLine("Sum ="+sum);
        }
    }
}
