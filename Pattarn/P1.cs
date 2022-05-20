using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattarn
{
    internal class P1
    {
        /*
         12345
         1234
         123
         12
         1
         */
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class P2
    {   /*
         1
         21
         321
         4321
         54321
         */
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
           
        }
        

    }
    class P7
    {
        /*
            5
            45
            345
            2345
            12345
         */
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i-- )
            {
                for(int j=i;j<=5;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class P3
    {     /*
           55555
           4444
           333
           22
           1
           */
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

        }
    }

    class P4
    {
        /*
        54321
        5432
        543
        54
        5
         */
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
    class P5
    { /*
       * 54321
       * 4321
       * 321
       * 21
       * 1
       */
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = (5-(i-1)); j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
    class P6
    {
        /* 5
         * 54
         * 543
         * 5432
         * 54321
         */
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

}
