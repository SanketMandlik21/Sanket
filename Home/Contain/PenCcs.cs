using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Contain
{
     class PenCcs
    {
        int caplength;
        string brand;
        Reli r=new Reli();
        Nib n = new Nib();
        public PenCcs()
        {

        }

        public PenCcs(int caplength, string brand, Reli r, Nib n)
        {
            this.caplength = caplength;
            this.brand = brand;
            this.r = r;
            this.n = n;
        }

        public int Caplength { get => caplength; set => caplength = value; }
        public string Brand { get => brand; set => brand = value; }
        internal Reli R { get => r; set => r = value; }
        internal Nib N { get => n; set => n = value; }
    }
    class Reli
    {
        string InkColour;
        int length;
        string Type;

        public Reli()
        {

        }
        public Reli(string inkColour, int length, string type, Nib n)
        {
            this.InkColour = inkColour;
            this.length = length;
            this.Type = type;
           
        }

        public string InkColour1 { get => InkColour; set => InkColour = value; }
        public int Length { get => length; set => length = value; }
        public string Type1 { get => Type; set => Type = value; }
        
    }
    class Nib
    {
        string Material;
        int width;
        public Nib()
        {

        }

        public Nib(string material, int width)
        {
            Material = material;
            this.width = width;
        }

        public string Material1 { get => Material; set => Material = value; }
        public int Width { get => width; set => width = value; }
    }
    class PenT
    {
        static void Main(string[] args)
        {
            PenCcs P1 = new PenCcs();
            P1.Caplength = 44;
            P1.Brand = "Avc";
            P1.R.InkColour1 = "San";
            P1.R.Length = 5;
            P1.R.Type1 = "WW";
            P1.N.Width = 55;
            P1.N.Material1 = "dsaf";
            Console.WriteLine("Caplength="+P1.Caplength);
            Console.WriteLine("Brand="+P1.Brand);
            Console.WriteLine("InkColour="+P1.R.InkColour1);
            Console.WriteLine("Length="+P1.R.Length);
            Console.WriteLine("Type="+P1.R.Type1);
            Console.WriteLine("Width"+P1.N.Width);
            Console.WriteLine("Material"+P1.N.Material1);
        }
    }


}
