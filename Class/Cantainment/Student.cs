using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Cantainment
{
   
    class Student
    {
        int studid;
        string name;
        int percent;
        Batch bacth1=new Batch();
        Address Address1=new Address();

        public Student(int studid, string name, int percent, Batch bacth1, Address address1)
        {
            this.studid = studid;
            this.name = name;
            this.percent = percent;
            this.bacth1 = bacth1;
            this.Address1 = address1;
        }
        public Student()
        {

        }
        public int Studid { get => studid; set => studid = value; }
        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }
        internal Batch Bacth1 { get => bacth1; set => bacth1 = value; }
        internal Address Address11 { get => Address1; set => Address1 = value; }
    }
    class Batch
    {
        string Bname;
        string Subject;
        public Batch()
        {

        }

        public Batch(string bname, string subject)
        {
            Bname1 = bname;
            Subject1 = subject;
        }

        public string Bname1 { get => Bname; set => Bname = value; }
        public string Subject1 { get => Subject; set => Subject = value; }
    }
    class Address
    {
        string addres;
        string city;

        public Address()
        {

        }
        public Address(string addres, string city)
        {
            this.addres = addres;
            this.City = city;
        }

        public string Addres1 { get => addres; set => addres = value; }
        public string City { get => city; set => city = value; }
    }
    class STest
    {
        static void Main(string[] args)
        {
            Student s1=new Student();
            s1.Studid = 10;
            s1.Name = "sanket";
            s1.Percent = 60;
            s1.Bacth1.Bname1 = "Microsoft";
            s1.Bacth1.Subject1 = "C#";
            s1.Address11.Addres1 = "Nashik";
            s1.Address11.City = "Pune";
            Console.WriteLine(s1.Studid);
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.Percent);
            Console.WriteLine(s1.Bacth1.Bname1);
            Console.WriteLine(s1.Bacth1.Subject1);
            Console.WriteLine(s1.Address11.Addres1);
            Console.WriteLine(s1.Address11.City);


        }
    }

}
