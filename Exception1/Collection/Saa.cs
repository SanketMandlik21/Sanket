using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Exception1.Collection
{
   class Student:IComparable
    {
        int Id;
        string Name;
        double percentage;

        public Student(int id, string name, double percentage)
        {
            Id1 = id;
            Name1 = name;
            this.Percentage = percentage;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public double Percentage { get => percentage; set => percentage = value; }

        public int CompareTo(Object o)
        {
            Student s = (Student)o;
            return s.Id1.CompareTo(s.Id1);
        }
        public override string ToString()
        {
            return $"Id{Id1}Name{Name1}Percentage{Percentage}";

        }
    }
    class A
    {
        static void Main(string[] args)
        {
            SortedList ss = new SortedList();
           
            ss.Add(new Student(01, "Sanket", 95.7), "Java");
            ss.Add(new Student(03, "Ashish", 90.5), ".Net");
            ss.Add(new Student(02, "Shubham", 85.6), "C++");
            ss.Add(new Student(04, "Chaityan", 95), "Test");

            foreach (DictionaryEntry e in ss)
                Console.WriteLine(e.Key + "" + e.Value);

        }
    }

    class Lista
    {
        static void Main(string[] args)
        {
            List<int>al = new List<int>();
            al.Add(1);
            al.Add(2);
            al.Add(3);
            foreach(int i in al)
            {
                Console.WriteLine(i);
            }

        }
    }
}











                   
