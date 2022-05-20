 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.For
{
    internal class Even2
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter The Number");
            int num=229;
            for (int i = 121; i <= 229; i++)
            {
                if(i%2==0)

                    Console.WriteLine(i);
            }
            
        }
    }

    class one
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if(i%2==0)
                    Console.WriteLine(i);
            }    
        }
    }

}
       