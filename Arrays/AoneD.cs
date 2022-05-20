using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Aeven
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int even = 0; int odd = 0;

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Enter {i}Element of");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
                Console.WriteLine("Even"+even);
                Console.WriteLine("Odd"+odd);
            }

        }
    }
    //Merging elements of two different arrays alternatively in third array 
    class Amarge
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 4, 8, 57 };
            int[] b = { 5, 6, 7, 8, };
            int[] c =new int [ a.Length + b.Length ];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
                
            }
            for(int i= 0; i < b.Length; i++)
            {
                c[i + a.Length] = b[i];
                
            }
            for(int i=0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
            
        }
    }

    class Aadd
    {
        static void Main(string[] args)
        {
            int[] a = {1,3,4,5,6,7};
            int[] b = {1,33,43,45,6,47};
            int []c=new int [5];

            for(int i= 0; i < a.Length; i++)
            {
                c [i] = a[i]+b[i];
                Console.WriteLine(c[i]);
            }
        }
    }
    
    class Aalter
    {
        static void Main(string[] args)
        {
            int [] a = {1,2,3,4,5};
            int[] b = {6,7,8,9,10};
            int[] c = new int[a.Length+b.Length];
            int t = 0;

           for(int i= 0; i < a.Length; i++)
            {
                c[t] = a[i];          
                t++;                                    
                                   
                c[t] = b[i];     
                t++;            
              
            }
           for(int i= 0; i < 10; i++)
            {
                Console.Write(c[i]);
            }

        }
    }
    //WAP to add elements to single dimensional int array and print elements from 1D array
    class Aone
    {
        static void Main(string[] args)
        {
            int[] a = new int[3];
            string[] s = {"sank","AShish","Chaitayan"};
            for(int i= 0; i < a.Length; i++)
            {
                Console.WriteLine(i);
            }
            foreach(string d in s)
            {
                Console.WriteLine(d);
            }


        }
    }
    //WAP to accept dimension of 1D array and create and accept data in that array.
    //Calculate the average value of array elements.

    class Aaverage
    {
        static void Main(string[] args)
        {
            int[] num = new int[]{40,5,4,4};
            int sum = 0;
            for(int i= 0; i < num.Length; i++)  
            sum=sum+num[i];
            Console.WriteLine("sum="+sum);
            double avg=sum/num.Length;
            Console.WriteLine("Average="+avg);
        }
    }
    //WAP to search for a given number in an array and accordingly print the index if exists.
    class Aindex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Accept the Number");

            double[] a = {5};
            double[] b = {3};
            double cal = 1;

            for(int i=0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            for (int i = 1; i <= a.Length; i++)
            {
                cal = cal * b[i];
            }
            Console.WriteLine("Cal"+cal);

        }
    }

    //WAP to print reverse of an array. Also print every alternate element backwards.
    class Areverse
    {
        static void Main(string[] args)
        {
            int[] num = { 1,2,3,4,5};
            for(int i= 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            for(int i = num.Length - 1; i>=0; i--)
            {
                Console.WriteLine(num[i]);
            }

        }
    }

    //WAP to print all negative elements
    //in an array and also count total number of negative elements in an array.
    class Anegative
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int n=0;
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine("Enter the element");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 0; i++)
            {
                if (a[i] < 0)
                {
                    n++;
                    
                }
            }
                
        }
    }
    //WAP to create a array of 10 elements and swap first two elements
    //with last two elements
    class Aswap
    {
        static void Main(string[] args)
        {

            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int h = 1;
            for(int i=1;i<=a.Length;i++)
            {
                if (h < a.Length)
                {
                    int temp=a[i];
                        a[i]=a[h];
                        a[h]=temp;
                        h++;
                }
                Console.Write(a[i]+"");
            }
            Console.WriteLine();

        }
    }
    class Array2
    {
        static void Main(string[] args)
        {
            int[,] aar1 = new int[5, 2];
           // int[,] aar2 = { { 1,2,3,4,5}, { 2,3,4,5,6} };
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Enter the element"+i);
                for(int j=0;j<2;j++)
                {
                    Console.WriteLine(j);
                }
            }

                
        }

        class Amax
        {
            static void Main(string[] args)
            {
               int [,]a=new int[5, 2];

            }
        }
    }
}












