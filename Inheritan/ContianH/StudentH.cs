using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritan.ContianH
{
    class StudentH
    {
        public  int Id, rollno;
        public string name;
        public double percentage;
        public long mobilen;
    }
    class TestD
    {
        static void Main(string[] args)
        {
            StudentH S1=new StudentH();
            S1.Id = 11;
            S1.name = "Sanket";
            S1.percentage = 60;
            S1.mobilen = 988565544;
            Console.WriteLine(S1.Id);
            Console.WriteLine(S1.name);
            Console.WriteLine(S1.percentage);
            Console.WriteLine(S1.mobilen);

            StudentH S2=new StudentH();
            Console.WriteLine("Enter Id,Name,Percentage,MobileNo ");
            S2.Id=Convert.ToInt32(Console.ReadLine());
            S2.name=Console.ReadLine();
            S2.percentage = Convert.ToDouble(Console.ReadLine());
            S2.mobilen= Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(S2.Id);
            Console.WriteLine(S2.name);
            Console.WriteLine(S2.percentage);
            Console.WriteLine(S2.mobilen);
        }
    }

    // Function 
    class FunH
    {
        public void Display()
        {
        Console.WriteLine( "Hiii Sanket" );
        }
        public int Add(int a,int b)
        {
            int sum=a+b;
            return sum;
        }
        public bool even(double a,string na)
        {
            if(a%2==0)
            
                return true;
            else 
                return false;
         
        }
    }
    class Fdetail
    {
        static void Main(string[] args)
        {
            FunH F=new FunH();
            F.Display();
            int Ans=F.Add(1,2);
            Console.WriteLine(Ans);
            bool As = F.even(34, "sam");
            Console.WriteLine(As);
        }
    }


















}
