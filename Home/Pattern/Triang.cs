using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Pattern
{
    internal class Triang
    {
        static void Main(string[] args)
        {
            int letter = 65;
            for (int i= 0; i < 7; i++)
            {
                for(int k= 0; k < 7-i; k++)
                {
                    Console.Write(" ");
                }
                for(int j= 0; j <=i; j++)
                {
                    Console.Write((char)(letter+j*2)+" ");
                }  
                Console.WriteLine(" ");
            }
        }
    }
}
 