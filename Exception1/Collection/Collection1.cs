using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exception1.Collection
{
    class Collection1
    {
        static void Main(string[] args)
        {
            ArrayList A1 = new ArrayList();
            A1.Add(10);
            Console.WriteLine(A1.Count);
            Console.WriteLine(A1.Capacity);
            A1.Add(20);
            A1.Add("Sanket");
            A1.Remove("Sanket");

            A1.Add("Sanketmandlik44@gmail.com");
            
            for(int i = 0; i < A1.Count; i++)
            {
                Console.WriteLine(A1.Count);
            }


        }
    }
    class Collection2
    {
        static void Main(string[] args)
        {
            ArrayList al=new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun ");
            al.Add("Mon ");
            al.Add("Sat ");
            al.Add("Sun ");
            al.Add("Sat ");
            al.Add("Sun ");
            al.Add("Mon ");
            Console.WriteLine("Array List Name"+al);
            foreach (var i in al)
            {
                Console.WriteLine(i + "=");
            }
            Console.WriteLine(" Remove Dublicate Data");
            for(int i=0; i < al.Count; i++)
            {
                string wrd=(string)al[i];
                while(al.IndexOf(wrd)!=al.LastIndexOf(wrd))
                {
                    int last=al.LastIndexOf(wrd);
                    al.Remove(last);
                }
                Console.WriteLine(wrd);
            }
            
            
        }
    }
    class Collection3
    {
        public static void Main()
        {

            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");

            Console.WriteLine("The ArrayList initially contains the following values:");
            PrintValues(myAL);
            
            myAL.Reverse();

            Console.WriteLine("After reversing:");
            PrintValues(myAL);
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.WriteLine(" {0}", obj);
            Console.WriteLine();
        }
    }

    class Collection4
    {
        static void Main(string[] args)
        {
            // Creating a Hashtable
            Hashtable myTable = new Hashtable();

            // Adding elements in Hashtable
            myTable.Add("1", "Even & Prime");
            myTable.Add("2", "Odd & Prime");
            myTable.Add("3", "Even & non-prime");
            myTable.Add("4", "Odd & non-prime");

            // Print the number of entries in Hashtable
            Console.WriteLine("Total number of entries in Hashtable : "
                                                      + myTable.Count);
            foreach (DictionaryEntry entry in myTable)
            {
                Console.WriteLine(entry.Key + "=" + entry.Value);
            }
            Console.WriteLine("Upadte Table ");
            //Upadte Table value
            myTable["2"] = "Prime Is Number";
            //Remove Table value
            myTable.Remove("1");
            Console.WriteLine("Remove Table");
            foreach(DictionaryEntry entry in myTable)
            {
                Console.WriteLine(entry.Key + "=" + entry.Value);
            }
            Console.WriteLine("Remove Count="+myTable.Count);
            
            
        }
    }
    class Collection5
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList()
            {
                "Pune","Nashik","Nashik","Pune","Nashik","Pune","Mumbai"
            };
            Hashtable ha = new Hashtable();
            //Pune =3,Nashik=3,Mumbai=1
            foreach(dynamic dis in myList)
            {
                if(ha.ContainsKey(dis))
                {
                    int ad =ha[dis];
                    ha[dis] = ad + 1;
                }
                else
                {
                    ha.Add(dis, 1);
                }
            }
            foreach(DictionaryEntry e in ha)
            {
                Console.WriteLine(e.Key +" "+e.Value);
            }
        }
    }
     
    class Collection6
    {
        static void Main(string[] args)
        {
            Hashtable myList = new Hashtable();
            myList.Add(10, "Sanket");
            myList.Add(12, "Ankush");
            myList.Add(11, "Ashish");
            myList.Add(14, "Shubham");
            myList.Add(15, "Chaityan");
            myList.Add(16, "Akashay");

            foreach(Object O in myList.Keys)
            {
                int data = (int)O;
                if (data % 3 == 0)
                {
                    Console.WriteLine(O + "" + myList[O]);
                }
                
            }

        }
    }

}

