using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Oops
{
    internal class Recurison
    {
        public static int factorial(int n)
        {
            if (n ==1)
             return 1;
            
            else
            {   
                int ans =factorial(n-1);
                return n*ans;
            }
            Console.WriteLine(n);
            
        }
    }
    class Fact2
    {
        static void Main(string[] args)
        {
         
           Recurison.factorial(10);
        }
    }
}
