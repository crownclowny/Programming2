using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handling_Constructors_in_InHeritance
{
    class Class2:class1
    {
        int c; // instance variable of this sub class

        public Class2(int a, int b, int c) : base(a, b) // the Constructor at this level; call the constructor of the base
        {
            this.c = c;
        }
        public override void add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("Executing the override add() from the child calss; the result is: " +z.ToString());
        }

    }
}
