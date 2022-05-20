using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.String2
{
    internal class Caseu1
    {
        static void Main(string[] args)
        {
            string ch;
            Console.WriteLine("Accept Number");
            ch =Console.ReadLine();
           string s= ch.ToUpper();
            Console.WriteLine(s);
            for(int i=0;i<ch.Length;i++)
            {
                Console.WriteLine(ch[i]);
            }
            for (int i= ch.Length - 1; i>=0;i--)
            {
                Console.WriteLine(ch[i]);
            }

        }
    }

    class Caseu2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Name");
            string ch=Console.ReadLine();
            bool sank = true;
            for(int i= 0;i<ch.Length;i++)
            {
                Console.WriteLine(ch[i]);
            }
            int end=ch.Length-1;
            for(int start=0;start<end;start++,end--)
            { 
                if(ch[start]==ch[end])
                {
                    sank=false;
                    break;
                }
            }
            if(sank==true)
            Console.WriteLine();

        }

    }
}
