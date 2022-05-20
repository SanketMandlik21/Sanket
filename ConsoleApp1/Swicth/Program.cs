using System;
namespace A
{
    class Demo
    {
        static void Main(String[] a)
        {
            Console.WriteLine("Enter name");
            string ? name=Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Heigth");
            float heigth= Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Gendar");
            char  Gendar= Convert.ToChar(Console.Read());
            Console.WriteLine("Name =" +name);
            Console.WriteLine("Age =" + age);
            Console.WriteLine("Heigth =" +heigth);
            Console.WriteLine("Gendar =" + Gendar);
            Console.Read();
           
        }
    }
}
