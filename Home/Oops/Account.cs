using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Oops
{
    internal class Account
    {
        long AccountNo;
        string AccountName;
        int blance;
        string type;


        public void display()
        {
            Console.WriteLine("Enter AccNo,AccName,Blance,Type");
            AccountNo = Convert.ToInt64(Console.ReadLine());
            AccountName = Console.ReadLine();
            blance = Convert.ToInt32(Console.ReadLine());
            type = Console.ReadLine();

        }
        public void deposite()
        {


        }
        public void withdraw()
        {

        }
    }
    class Acc
    {
        static void Main(string[] args)
        {

        }

    }

}

