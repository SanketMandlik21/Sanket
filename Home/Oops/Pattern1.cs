using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Oops
{
  class Prent
  {
        public virtual void play()
        {
            Console.WriteLine("Hii SANKET");
        }
        internal  void study()
        {
            Console.WriteLine("H"); 
        }
        
  }
    class Child:Prent
    {
        public  override void play()
        {
            Console.WriteLine("DJkd");
        }
        internal void study()
        {
            Console.WriteLine("rkjt");
        }

    }
    class Study
    {
        static void Main(string[] args)
        {
            Prent P1 = new Child();
            P1.play();
            P1.study();
            Child P2 = new Child();
            P2.play();
            P2.study();

        }
    }

    
}
