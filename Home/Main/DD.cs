using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritan.In;

namespace Home.Main
{
  
    class Vechical
    { 
        public void Model()
        {

        }
        public  void Feature()
        {

        }
        public void Noise()
        {
           Console.WriteLine("I am an animal");
        }

    }
        class Inheri : Vechical
        {
            static void Main(string[] args)
            {
            Inheri Obj = new Inheri();
            Obj.Noise();
            Obj.Model();
            Obj.Feature();
            }
                      
        }

   
    
}
