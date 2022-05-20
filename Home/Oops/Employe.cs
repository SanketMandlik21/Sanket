using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Oops
{
    class Employe
    {
        int EmpId;
        string EmpName;
        Deparment D = new Deparment();
        public Employe()
        {

        }

        public Employe(int empId, string empName, Deparment d)
        {
            EmpId1 = empId;
            EmpName1 = empName;
            D1 = d;
        }

        public int EmpId1 { get => EmpId; set => EmpId = value; }
        public string EmpName1 { get => EmpName; set => EmpName = value; }
        internal Deparment D1 { get => D; set => D = value; }
    }
    class Deparment
    {
        string Depname;
        int DepId;
        public Deparment()
        {

        }

        public Deparment(string depname, int depId)
        {
            Depname1 = depname;
            DepId1 = depId;
        }

        public string Depname1 { get => Depname; set => Depname = value; }
        public int DepId1 { get => DepId; set => DepId = value; }
    }
    class DetailE
    {
        static void Main(string[] args)
        {
            Employe E1 = new Employe();
            E1.EmpId1 = 11;
            E1.EmpName1 = "Sanket";
            E1.D1.Depname1 = "Computer Network";
            E1.D1.DepId1 = 01;
            Console.WriteLine("Employee name ="+E1.EmpName1);
            Console.WriteLine("Employee ID ="+E1.EmpId1);
            Console.WriteLine("Deparment Name ="+E1.D1.Depname1);
            Console.WriteLine("Deprment Id ="+E1.D1.DepId1);

        }

    }
}
