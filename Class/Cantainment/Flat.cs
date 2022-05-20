using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Cantainment
{
    internal class Flat
    {
        int flatn;
        string flatnamel;
        int flatfo;
        ContractM c1=new ContractM();
        public Flat()
        {

        }

        public int Flatn { get => flatn; set => flatn = value; }
        public string Flatnamel { get => flatnamel; set => flatnamel = value; }
        public int Flatfo { get => flatfo; set => flatfo = value; }
        internal ContractM C1 { get => c1; set => c1 = value; }
    }
    class ContractM
    {
        string ownern;
        char n;
        long mobile;

        public ContractM()
        {

        }

        public string Ownern { get => ownern; set => ownern = value; }
        public char N { get => n; set => n = value; }
        public long Mobile { get => mobile; set => mobile = value; }
    }
    class BDetails
    {
        static void Main(string[] args)
        {
            Flat f1 = new Flat();
            f1.Flatnamel = "Shri";
            f1.Flatn = 407;
            f1.Flatfo = 4;
            f1.C1.Ownern = "shubham";
            f1.C1.N = 'S';
            f1.C1.Mobile = 988555;
            Console.WriteLine("Flat name ="+f1.Flatnamel);
            Console.WriteLine("Flat Number ="+f1.Flatn);
            Console.WriteLine("Flat Flour ="+f1.Flatfo);
            Console.WriteLine("Ownar Name ="+f1.C1.Ownern);
            Console.WriteLine("Flat ="+f1.C1.N);
            Console.WriteLine("Ownar Moblie ="+f1.C1.Mobile);


        }
    }
}
