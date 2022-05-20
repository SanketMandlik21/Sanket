using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.For
{
    internal class Digitp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int Cou;
            for( Cou=0;num>0;num=num/10)
            {
                Cou = Cou + 1;
            }
            Console.WriteLine("Count="+Cou);
        }
    }
}
