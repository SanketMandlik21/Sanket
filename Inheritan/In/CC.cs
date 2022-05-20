using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritan.In
{
    public class CC
    {
        string sa;
        int ss;

        public string Sa { get => sa; set => sa = value; }
        public int Ss { get => ss; set => ss = value; }

        public CC()
        {
            Console.WriteLine("Hiii");
        }
        static void Main(string[] args)
        {
            CC c=new CC();

        }
    }

}