using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattarn
{
    internal class Apl
    {
        /*
         ABCDE
         ABCD
         ABC
         AB
         A
         */
        static void Main(string[] args)
        {
            for(char i='E';i>='A';i--)
            {
                for(char j='A';j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class A2
    {
        /* 
          EDCBA
          EDCB
          EDC
          ED
          E
         */
        static void Main(string[] args)
        {
            char i='A';
            char j='E';
            for(i='A';i<='E';i++)
            {
                for(j='E';j>=i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class A3
    {
        /*
         A
         AB
         ABC
         ABCD
         ABCDE
         */
        static void Main(string[] args)
        {
            for(char i='A';i<='E';i++ )
            {
                for (char j = 'A'; j <=i;j++)
                {
                    Console.Write(j);

                }
                Console.WriteLine(" ");
            }
        }
    }
    class A4
    {
        /*
         E
         ED
         EDC
         EDCB
         EDCBA
         */
        static void Main(string[] args)
        {
            for(char i='E';i>='A';i--)
            {
                for(char j='E';j>=i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine(" ");
            }
        }
    }
    class A5
    {
        /*
         EEEEE
         DDDD
         CCC
         BB
         A
         */
        static void Main(string[] args)
        {
            for(char i='E';i>='A';i--)
            {
                for(char j='A';j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    class A6
    {
        /*  
         *  AAAAA
            BBBB
            CCC
            DD
            E
        */
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'E'; j >= i; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }   
        }
    }

    class A7
    {
        /*A
          BA
          CBA
          DCBA
          EDCBA
         * */
        static void Main(string[] args)
        {
            for(char i='A';i<='E';i++)
            {
                for (char j =i;j>='A';j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class A8
    {
        /*
         * E
           DE
           CDE
           BCDE
           ABCDE
         */
        static void Main(string[] args)
        {
            for(char i='E';i>='A'; i--)
            {
                for (char j = i; j <= 'E'; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
