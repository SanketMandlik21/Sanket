using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Class
{

    class Details
    {
        int StudentID;
        string StudentName;
        int Age;
        string Country;

        public Details(int studentID, string studentName, int age, string country)
        {
            StudentID1 = studentID;
            StudentName1 = studentName;
            Age1 = age;
            Country1 = country;
        }

        public int StudentID1 { get => StudentID; set => StudentID = value; }
        public string StudentName1 { get => StudentName; set => StudentName = value; }
        public int Age1 { get => Age; set => Age = value; }
        public string Country1 { get => Country; set => Country = value; }

        public override string ToString()
        {
            return $"StudentID: {this.StudentID} - StudentName: {this.StudentName} - Age: {this.Age} - Country: {this.Country}";
        }
        
    }

    class Student
    {
        static void Main(string[] args)
        {
            List<Details> studentList = new List<Details>() {
                new Details ( 1, "John",18, "Poland"  ) ,
                new Details (  2, "Steve",  22, "Poland" ) ,
                new Details (3,  "Bill",   18,  "USA"  ) ,
                new Details ( 4,  "Ram" ,  20,  "USA"  ) ,
                new Details(  5, "Ron" ,  21,  "Germany"  )
            };
        }

    }
    
 
        class GFG
        {

            // Main Method
            public static void Main()
            {

                // Declare the Jagged Array of four elements:
                int[][] jagged_arr = new int[4][];

                // Initialize the elements
                jagged_arr[0] = new int[] { 1, 2, 3, 4 };
                jagged_arr[1] = new int[] { 11, 34, 67 };
                jagged_arr[2] = new int[] { 89, 23 };
                jagged_arr[3] = new int[] { 0, 45, 78, 53, 99 };

                // Display the array elements:
                for (int n = 0; n < jagged_arr.Length; n++)
                {

                    // Print the row number
                    System.Console.Write("Row({0}): ", n);

                    for (int k = 0; k < jagged_arr[n].Length; k++)
                    {

                        // Print the elements in the row
                        System.Console.Write("{0} ", jagged_arr[n][k]);
                    }
                    System.Console.WriteLine();
                }
            }
        }

    class Dell
    {


    }
    
}
