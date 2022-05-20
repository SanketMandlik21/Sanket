using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Atwod
    {
        static void Main(string[] args)
        {
            int[,] aar = new int[3, 4];
            int[][]a=new int[3][];
            a[0]= new int[1];
            a[1]= new int[2];
            a[2]= new int[3];
            for (int i = 0; i < a.GetLength(0); i++)
            {
               
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }  
             
        }
    }
}
