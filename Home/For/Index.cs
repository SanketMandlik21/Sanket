using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.For
{
    internal class Index
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Accept the base ");
            double bas, index;
            bas = Convert.ToDouble(Console.ReadLine());
            index = Convert.ToDouble(Console.ReadLine());
            double cal = 1;
            
            for (int i =1;i<=index;i++)
            {
                cal=cal*bas;
               
            }
            Console.WriteLine("Calculate="+cal);  
        }
    }
}
