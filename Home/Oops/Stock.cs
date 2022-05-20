using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Oops
{
    internal class Stock
    {
        string stockName;
        string stockId;
        double stockPrice;

        public void SetName(string N)
        {
            stockName = N;
        }
        public string GetName()
        {
            return stockName;
        }
        public void SetStockId(string ID)
        {
            stockId = ID;
        }
        public string GetID()
        {
            return stockId;
        }
        public void SetStockP(double P)
        {
            stockPrice = P;
        }
        public double GetP()
        {
            return stockPrice;
        }
    }
      class Data
      { 
        static void Main(string[] args)
        {
            Console.WriteLine("Stock Details");
            Stock S = new Stock(); 
            Console.WriteLine("Stock Name");
            string name=(Console.ReadLine());
            S.SetName(name);
            Console.WriteLine("Stock Id");
            string id=Console.ReadLine();
            S.SetStockId(id);
            Console.WriteLine("Stock Price");
            int p=Convert.ToInt32(Console.ReadLine());
            S.SetStockP(p);
            Console.WriteLine(S.GetName());
            Console.WriteLine(S.GetID());
            Console.WriteLine(S.GetP());

            Stock S2=new Stock();
            S2.SetName("Tata");
            S2.SetStockId("1");
            S2.SetStockP(555);
            Console.WriteLine(S2.SetName);
            Console.WriteLine(S2.SetStockId);
            Console.WriteLine(S2.SetStockP);
             
            Stock S3=new Stock();
            Console.WriteLine(S3.GetName());
            Console.WriteLine(S3.GetID());
            Console.WriteLine(S3.GetP());
            
        }

      }
    
}
