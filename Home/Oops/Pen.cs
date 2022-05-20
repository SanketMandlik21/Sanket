using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Oops
{
    internal class Pen
    {
        int Price;
        string Name;
        string Description;
        int quntity;

        public void display()
        {
            Console.WriteLine("Pan Detail infromation");
            Price = Convert.ToInt32(Console.ReadLine());
            Name = Console.ReadLine();
            Description = Console.ReadLine();
            quntity = Convert.ToInt32(Console.ReadLine());
        }
        public void SetPrice(int P)
        {
            Price = P;
        }
        public int Getp()
        {
            return Price;
        }
        public void SetName(string na)
        {
            Name = na;
        }
        public string Getn()
        {
            return Name;
        }
        public void SetDes(string D)
        {
            Description = D;
        }
        public string GetDa()
        {
            return Description;

        }
        public void Setqunity(int q)
        {
            quntity = q;
        }
        public int GetQ()
        {
            return quntity;
        }
        public Pen()
        {

        }
        public Pen(int Pri, string Ne)
        {
            Price = Pri;
            Name = Ne;

            }
        public Pen(string Des, int qunt)
        { 
            Description=Des;
            quntity=qunt;
        }

    }
    class PenD
    {
        static void Main(string[] args)
        {
            Pen p = new Pen(21, "San");
            Console.WriteLine( "quantity=" + p.GetQ()+ "Pen name =" + p.Getn() );

            Pen p2 = new Pen("Sana", 55);
            Console.WriteLine("Pen name =" + p2.Getn() + "quantity=" + p2.GetQ());

            Pen p3 = new Pen();
            p3.SetName("ss");
            Console.WriteLine("Pen name "+p3.Getn() );
            
        }
    }

}
