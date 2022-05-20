using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Oops
{
    class Techar
    {
        int Tid;
        long Mobileno;
        public Techar()
        {

        }
        public Techar(int tid, long mobileno)
        {
            Tid1 = tid;
            Mobileno1 = mobileno;
        }

        public int Tid1 { get => Tid; set => Tid = value; }
        public long Mobileno1 { get => Mobileno; set => Mobileno = value; }
    }
    class Hourlybased : Techar
    {
        int rate_per;
        int har;

        public Hourlybased()
        {

        }

        public Hourlybased(int rate_per, int har, int Tid, long Mobileno) : base(Tid, Mobileno)
        {
            this.Rate_per = rate_per;
            this.Har = har;
        }

        public int Rate_per { get => rate_per; set => rate_per = value; }
        public int Har { get => har; set => har = value; }

        void Salary()
        {
            int salary = Rate_per * Har;
            Console.WriteLine("Salary=" + salary);
        }
    }

    class SalaryB:Techar
    {
        string field;
        int salary;

        public SalaryB()
        {   
        }

        public SalaryB(string field, int salary,int Tid,long Mobileno):base(Tid, Mobileno)
        {
            this.Field = field;
            this.Salary1 = salary;
        }
        public override string ToString()
        {
            return $"name={Field},Salary={Salary1},Tid={Tid1},Mobile{Mobileno1}";
        }

        public string Field { get => field; set => field = value; }
        public int Salary1 { get => salary; set => salary = value; }

        public void Salary()
        {
            Console.WriteLine( "Salary"+Salary1);
        }
    }
    class Teach
    {
        static void Main(string[] args)
        {
            Techar T1 = new Hourlybased(10, 100, 55, 54424);
            Console.WriteLine("Enter Salary,moblie,id,name");
            int Sala = Convert.ToInt32(Console.ReadLine());
            long mobile = Convert.ToInt64(Console.ReadLine());
            int id=Convert.ToInt32(Console.ReadLine());
            string name=Console.ReadLine();
            Techar T2 = new SalaryB(name, Sala, id, mobile);
            Console.WriteLine(T2.Mobileno1);
            Console.WriteLine(T2);



        }
    }

}
