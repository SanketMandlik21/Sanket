using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Oops
{
     class Person
    {
        string name;
        int age;
        string Vehical;
        Car C=new Car();
        public Person()
        {

        }
        public Person(string name, int age, string vehical, Car c)
        {
            this.Name = name;
            this.Age = age;
            Vehical1 = vehical;
            C1 = c;
        }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Vehical1 { get => Vehical; set => Vehical = value; }
        internal Car C1 { get => C; set => C = value; }
    }
    class Car
    {
        string carname;
        int vid;
        public Car()
        {

        }

        public Car(string carname, int vid)
        {
            this.Carname = carname;
            this.Vid = vid;
        }

        public string Carname { get => carname; set => carname = value; }
        public int Vid { get => vid; set => vid = value; }
    }
    class CarT
    {
        static void Main(string[] args)
        {
            Person P1=new Person();
            P1.Name = "Sanket";
            P1.Age = 25;
            P1.C1.Carname = "Tata";
            P1.C1.Vid = 55;
            Console.WriteLine("Name="+P1.Name);
            Console.WriteLine("Age="+P1.Age);
            Console.WriteLine("Car Name="+P1.C1.Carname);
            Console.WriteLine("Vid ="+P1.C1.Vid);

        }
    }
}
