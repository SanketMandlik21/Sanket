using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Oops
{
    internal class Movie
    {
        string moviename;
        string director;
        string producer;
        string maleactor;
        float rating;

        public void SetMovieN(string m)
        {
            moviename = m;
        }
        public string GetM()
        {
            return moviename;
        }
        public void SetMdirector(string d)
        {
            director = d;
        }
        public string GetD()
        {
            return director;
        }
        public void Setproducer(string P)
        {
            producer = P;
        }
        public string GetP()
        {
            return producer;
        }
        public void SetMaleactor(string ma)
        {
            maleactor = ma;
        }
        public string GetMA()
        {
            return maleactor;
        }
    }

        class Cust
        {
            static void Main(string[] args)
            {
                Movie M = new Movie();
                M.SetMovieN("San");
                M.SetMdirector("aa");
                M.Setproducer("SS");
                M.SetMaleactor("SSa");
                Console.WriteLine(M.SetMovieN);
                Console.WriteLine(M.SetMdirector);
                Console.WriteLine(M.Setproducer);
                Console.WriteLine(M.SetMaleactor);



                Movie M2 = new Movie();
                Console.WriteLine("Details Movie");
                M2.SetMovieN(Console.ReadLine());
                M2.SetMdirector(Console.ReadLine());
                M2.Setproducer(Console.ReadLine());
                M2.SetMaleactor(Console.ReadLine());

                Console.WriteLine( M2.SetMovieN);
                Console.WriteLine(M2.SetMdirector);
                Console.WriteLine( M2.Setproducer);
                Console.WriteLine( M2.SetMaleactor);



            }
        }

        
}

