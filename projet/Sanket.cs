using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace projet
{
    class Sanket
    {
        public int Scorer=0;
        ArrayList al = new ArrayList();
        ArrayList Q1op=new ArrayList();
        ArrayList Q2op=new ArrayList();
        ArrayList Q3op=new ArrayList();
        ArrayList Q4op=new ArrayList();
        SortedList sl=new SortedList();

        public void AddJavaQution()
        {
            al.Add("\tQ1.Which of the following option leads to the portability and security of Java?");
            Q1op.Add("\t\t1.Bytecode is executed by JVM");
            Q1op.Add("\t\t2.The applet makes the Java code secure and portable");
            Q1op.Add("\t\t3.Use of exception handling");
            Q1op.Add("\t\t4.Dynamic binding between objects");
            Q1op.Add(1);

        }

    }
}
