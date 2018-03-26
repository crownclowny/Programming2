using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handling_Constructors_in_InHeritance
{
    class class1
    {
        protected int a, b;
        public class1() // constructor default
        {
            a = 0;
            b = 0;
            Console.WriteLine("Reporting From the base default constructor");
        }
        public class1(int a, int b)// Overload base constructor default
        {
            this.a = a;
            this.b = b;
        }
        public virtual void add(int x, int y)
        {
            int z = x * y;
            Console.WriteLine("Executing the base add(); the Result is: "+z.ToString());
        }

       

  }
}
