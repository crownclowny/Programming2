using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XX_CentStudent
{
    class Hernandez_CentStudent
    {
        //instance variables
        private int stdID;
        private string stdName;
        private double stdFee;

        //property
        public string stdStatus
        { get; set; }

        //constructor

        private Hernandez_CentStudent()
        {
        }
        private Hernandez_CentStudent(int stdID)
        {
            this.stdID = stdID;
        }
        private Hernandez_CentStudent(int stdID, string stdName)
        {
            this.stdID = stdID;
            this.stdName = stdName;

        }

        private Hernandez_CentStudent(double stdFee)
        {
            this.stdFee = stdFee;

        }

        //method
        public int StdID
        {
            set { this.stdID = value; }
            get { return this.stdID; }

        }

        public string StdName
        {
            set { this.stdName = value; }
            get { return this.stdName; }

        }

        public double StdFee
        {
            set { this.stdFee = value; }
            get { return this.stdFee; }
        }

        
        //Overriding Tostring()
        public override string ToString()
        {
            return string.Format("Students Name: ", StdName);
        }

        //Operator overloading for + 
        public static Hernandez_CentStudent operator +(Hernandez_CentStudent a, Hernandez_CentStudent b)
        {
            Hernandez_CentStudent Centstudent = new Hernandez_CentStudent();
            Centstudent.stdName = a.stdName+ b.StdName;
           return Centstudent;
        }

      
        static void Main(string[] args)
        {
           

            

            Hernandez_CentStudent A = new Hernandez_CentStudent(300964840);
            Console.WriteLine("The students ID is: " + A.stdID);

            Hernandez_CentStudent B = new Hernandez_CentStudent( 300964840,"Tom");
            Console.WriteLine("The students Name is " + B.stdName);


            Hernandez_CentStudent c = new Hernandez_CentStudent(1500.00);
            Console.WriteLine("The students Fee IS: " + c.StdFee);


            Console.WriteLine("please enter a new student ID");


             Console.ReadKey();
        }

        
    }
}
