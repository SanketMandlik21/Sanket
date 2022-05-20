using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattarn
{
    internal class PP2
    {
        static void Main(string[] args)
        {
            int k = 4;
            for(int i=6;i>=1;i--)
            {
                for(int r=1;r<=6-i;r++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }


        }
    }
}
