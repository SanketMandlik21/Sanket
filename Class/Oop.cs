using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Oop
    {
        public int Price, BookNo;
        public string Name, Writer;
        public int publishD;

   
        static void Main(string[] args)
        {
            Oop O1 = new Oop();
            O1.Price = 35;
            O1.BookNo = 1;
            O1.Name = "Java";
            O1.Writer = "Xyz";
            O1.publishD = 22;
            Console.WriteLine($"Price{O1.Price} BookNO{O1.BookNo} Name{O1.Name} Writer{O1.Writer} PublishD{O1.publishD}");

            Oop O2 = new Oop();
            Console.WriteLine("Enter Price");
            O2.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter BookNo");
            O2.BookNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Name");
            O2.Name  = Console.ReadLine();
            Console.WriteLine("Enter Writer Name");
            O2.Writer = Console.ReadLine();
            Console.WriteLine("Enter Publish Date");
            O2.publishD = Convert.ToInt32(Console.ReadLine()); 




        }
    }
    class Book
    {
      public void Display()
        {
            Console.WriteLine("Enter Price");
            int Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter BookNo");
            int BookNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Writer Name");
            string Writer = Console.ReadLine();
            Console.WriteLine("Enter Publish Date");
            int publishD = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Display();
        }
    }
}
