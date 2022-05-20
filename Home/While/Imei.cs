using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.While
{
    internal class Imei
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            long a=Convert.ToInt64(Console.ReadLine());
            long num=  a;
            int c=0;
            while (num > 0)
            {
                c++;
                num = num / 10;

            }
            Console.WriteLine("Number Of Digit"+c);

            if (c == 15)
            {
                int sum = 0;
                int k = 1;
                while(k>0) 
                {
                    k++;
                    int d = (int)(num % 10);
                    num = num / 10;
                    if (num % 2 == 0)
                        sum = sum + d;
                    else
                    {
                        int twic = 2 * d;

                        if (twic <= 9)
                            sum = sum + twic;
                        else
                            sum = sum + twic + twic % 10;
                    }



                   
                }
            }
        }
    }
}
