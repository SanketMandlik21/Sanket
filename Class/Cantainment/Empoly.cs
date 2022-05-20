using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Cantainment
{
    class Empoly
    {
        int eid;
        string ename;
        int salary;
        Deparament D1 = new Deparament();

        public Empoly()
        {

        }

        public Empoly(int eid, string ename, int salary, Deparament d1)
        {
            this.eid = eid;
            this.ename = ename;
            this.salary = salary;
            D1 = d1;
        }

        public int Eid { get => eid; set => eid = value; }
        public string Ename { get => ename; set => ename = value; }
        public int Salary { get => salary; set => salary = value; }
        public Deparament D11 { get => D1; set => D1 = value; }

    }
    class Deparament
    {
        int dno;
        string dname;
        string dManganer;

        public Deparament()
        {

        }

        public int Dno { get => dno; set => dno = value; }
        public string Dname { get => dname; set => dname = value; }
        public string DManganer { get => dManganer; set => dManganer = value; }
    }
    class Edetails
    {
        static void Main(string[] args)
        {
            Empoly e1=new Empoly();
            e1.Eid = 11;
            e1.Ename = "Ashish";
            e1.Salary = 50000;
            e1.D11.Dno = 55;
            e1.D11.Dname = "Computer";
            e1.D11.DManganer = "Saas";
            Console.WriteLine(e1.Eid);
            Console.WriteLine(e1.Ename);
            Console.WriteLine(e1.Salary);
            Console.WriteLine(e1.D11.Dno);
            Console.WriteLine(e1.D11.Dname);
            Console.WriteLine(e1.D11.DManganer);
           


        }
    }


    
}
