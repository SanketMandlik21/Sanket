using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Words
    {
        static public int Frqu(string str,char ch)
        {
            int i = 0;
            for(i = 0; i < str.Length; i++)
            {
                if(ch == str[i])
                    i++;
            }
            return i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Frist String");
            string str=Console.ReadLine();
            Console.WriteLine("Enter Second String");
            string str1=Console.ReadLine();
            for(int i=0; i<str.Length; i++)
            {

            }
           
        }
    }
    class Join
    {
        public static void Main(string[] args)
        {

            // create string
            string str1 = "C# ";
            Console.WriteLine("string str1: " + str1);

            // create string
            string str2 = "Programming";
            Console.WriteLine("string str2: " + str2);

            // join two strings
            string joinedString = string.Concat(str1, str2);
            Console.WriteLine("Joined string: " + joinedString);

            Console.ReadLine();
        }
    }
    
    class StringRev
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter the Strings");
            string revs = "";
            int Length = 0;
            str=Console.ReadLine();
            Length = str.Length - 1;
            while(Length >= 0)
            {
                revs=revs+str[Length];
                Length--; 
            }
            Console.WriteLine("Revve=" + revs);
            Console.ReadLine();
        }
    }
}
