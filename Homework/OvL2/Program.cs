using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvL2
{
    class Box
    {
        //instance variable
        private double length;
        private double breath;
        private double height;

        //method setBox: sets all the instance variables with values
        public void setBox(double l, double b, double h)
        {
            length = l;
            breath = b;
            height = h;
        }

        public double getlength()
        {
            return length;
        }

        public double getbreath()
        {
            return breath;
        }

        public double getheight()
        {
            return height;
        }

        //Operator overloading for + and === and not =
        public static Box operator +(Box a, Box b)
        {
            Box box = new Box();
            box.length = a.length + b.length;
            box.breath = a.breath + b.breath;
            box.height = a.height + b.height;
            return box;
        }

        public static bool operator ==(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length == rhs.length&&lhs.breath==rhs.breath&&lhs.height==rhs.height) ;
            {
                status = true;
            }

            return status;

        }


        public static bool operator !=(Box lhs, Box rhs)

        {
            bool status = false;
            if (lhs.length != rhs.length || lhs.breath != rhs.breath || lhs.height != rhs.height) ;

            {
                status = true; 
            }
            return status;

        }

        //Overriding Tostring()
        public override string ToString()
        {
            return string.Format("length: {0},breath:{1},height:{2}", length, breath, height);
        }



        static void Main(string[] args)
        {
            Box box1 = new Box();
            box1.setBox(7.0, 6.0, 8.0);

            Box box2 = new Box();
            box2.setBox(8.0, 7.0,6.0);

            Box box3 = new Box();
            box3 = box1 + box2;

            Box box4 = new Box();
            box4.setBox(7.0, 6.0, 8.0);

            Console.WriteLine(box3);

            if (box1 == box2)
            {
                Console.WriteLine("Boxes you supplied are identical in their dimensions");
            }
            else Console.WriteLine("Boxes you supplies are not identical in their dimensions");


            if (box1 == box4)
            {
                Console.WriteLine("Boxes you supplied are identical in their dimensions");
            }
            else Console.WriteLine("Boxes you supplies are not identical in their dimensions");


            Console.ReadKey();


        }
    }
}
