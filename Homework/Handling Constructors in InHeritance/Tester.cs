using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handling_Constructors_in_InHeritance
{
    class Tester
    {
        public static void Main()
        {
            class1 cl1 = new class1();
            Class2 cl2 = new Class2(1, 5, 7);

            Console.ReadKey();

            cl1.add(1, 2);
            cl2.add(2, 4);

            Console.ReadKey();

        }
        
    }
}
