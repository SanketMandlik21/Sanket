using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Pattern
{
    internal class K
    {
        static void Main(string[] args)
        {
            int row = 15;
            int end=row;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= end; j++)
                {
                    if (j == 1 || j == end)
                        Console.Write("*0");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine(" ");

                if (i<=row)
                {
                    end = end - 2;
                }

                {
                    end = end + 2;
                };
            }

        }
    }
}
