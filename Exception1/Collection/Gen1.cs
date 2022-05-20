using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Exception1.Collection
{
   class Gen1
   {
      static void Main(string[] args)
      { 
            LinkedList<int> al=new LinkedList<int>();
                al.AddLast(1);
                al.AddLast(200);
                al.AddLast(31);  
                al.AddLast(424);
            LinkedListNode<int> node = al.Find(31);
            al.AddAfter(node,500);
            foreach(int i in al)
                Console.WriteLine(i);
      }
   }

    //1.WAP to sort the elements of List that contains String objects. Print List

    class GFG
    {

     
        public static void Main()
        {

            // List initialize
            List<string> list1 = new List<string> 
            {
                "Sanket","Ashish","Shubham","Akashay","Pooja","Priti","Chaityan"
            };

            Console.WriteLine("Original List");

            foreach (string g in list1)
            {
                Console.WriteLine(g);
            }

            Console.WriteLine("\nSorted List");

            // use of List<T>.Sort() method
            list1.Sort();

            foreach (string g in list1)
            {
                Console.WriteLine(g);
            }
        }
    }

    //2.2.	WAP to create a class Employee with (name, designation ,salary).
    //Now create and add Employee objects elements to List. Print List.

    class Emp1
    {
        string name;
        string designation;
        int salary;

        public Emp1(string name, string designation, int salary)
        {
            this.Name = name;
            this.Designation = designation;
            this.Salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Salary { get => salary; set => salary = value; }

        static void Main(string[] args)
        {
            LinkedList<Emp1> emp = new LinkedList<Emp1>();
           
            
            

        }
    }

    //3.WAP to create a Queue with some colors (String) using generics.
    class Que
    {
        static public void Main()
        {

            Queue my_queue = new Queue();
            // Adding elements in Queue
            my_queue.Enqueue("Red");
            my_queue.Enqueue("White");
            my_queue.Enqueue("Green");
            my_queue.Enqueue("Blue");
            my_queue.Enqueue("Black");
            my_queue.Enqueue("Yellow");
            my_queue.Enqueue("Pink");

            Console.WriteLine(my_queue.Peek());

            // Using foreach loop
            foreach (dynamic ele in my_queue)
            {
                Console.WriteLine(ele);
            }
        }
    }

    //4.	WAP to add user defined objects of type Employee in a HashSet employee object.
    //Make sure if I create 2 different objects with same data the other one should not be added as hashset stores
    //unique objects.

   /* class HashSet
    {
        static void Main(string[] args)
        {
            HashSet<object> hs = new HashSet<object>();
            hs.Add(new Employee("suraj", "sr.developer", 25000));
            hs.Add(new Employee("amit", "project lead", 50000));
            hs.Add(new Employee("ritik", "QA", 20000));
            hs.Add(new Employee("suraj", "jr.developer", 15000));
            hs.Add(new Employee("suraj", "sr.developer", 25000));

            foreach (dynamic d in hs)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();

            for (int i = 0; i < hs.Count; i++)
            {
                Console.WriteLine();
            }
        }
    }*/

    //5.	WAP to create SortedList where key is of Integer type and value string and print all key-value pairs.
    class Sort
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(5, "suraj");
            sl.Add(2, "smita");
            sl.Add(6, "jeevan");
            sl.Add(4, "neha");
            foreach (var v in sl)
            {
                Console.WriteLine(v.Key + " " + v.Value);
            }


        }
    }



    //6.	WAP to create Dictionary where key is of string type and value of float type and print all key-value pairs.
    class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(3, "Sanket3");
            d.Add(2, "Sanket2");
            d.Add(8, "Sanket5");
            d.Add(6, "Sanket6");
            d.Add(4, "Sanket4");
            d.Add(1, "Sanket1");


            foreach (KeyValuePair<int, string> de in d)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }
        }
    }
    
    //7.	Make use of such collection that stores moviename such that last entered movie is first
    //      deleted and accordingly previous one.
    class Stack
    {
        static void Main(string[] args)
        {

            Stack<string> st = new Stack<string>();
            st.Push("zindagi na milegy dobara");
            st.Push("vivah");
            st.Push("hum aapke hain kon");
            st.Push("singham");
            st.Push("wanted");

            foreach (var v in st)
            {
                Console.WriteLine(v);

            }
            st.Pop();
            st.Pop();
            Console.WriteLine();
            Console.WriteLine("After Pop Operation:");
            foreach (var v in st)
            {
                Console.WriteLine(v);

            }
        }

    }


}
