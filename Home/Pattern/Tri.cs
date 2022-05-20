using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Pattern
{
   
        internal class Tri
        {
            static void Main(string[] args)
            {

                for (int i = 1; i <= 15; i++)
                {
                    for (int c = 1; c <= i; c++)
                    {

                        Console.Write("#");
                    }
                    Console.WriteLine("");

                }
            }
        }
        class Return
        {
            static void Main(string[] args)
            {
                for (int i = 5; i >= 1; i--)
                {
                    for (int c = 1; c <= i; c++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine("");

                }

            }
        }
        class One
        {
            static void Main(string[] args)
            {
                int i, j;

                for (i = 1; i <= 5; i++)
                {

                    for (j = i; j >= 1; j--)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();

                }
            }
        }
        class Five
        {
            static void Main(string[] args)
            {
                int i, j;

                for (i = 5; i >= 1; i--)
                {

                    for (j = i; j <= 5; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();

                }

            }
        }
         
    }

