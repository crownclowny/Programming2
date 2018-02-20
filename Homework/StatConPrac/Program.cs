using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatConPrac
{
    public  class Bus
    {
        //static member (variable) used by all Bus instances 
        protected static readonly DateTime globalStartTime;
        
        //property for the number of each Bus
        protected int RouteNumber { get; set; }

        //static constructor to initialize the static variable
        //it is invoked before the first instance constructor is run (when the first object is created)
        static Bus()
        {
            globalStartTime = DateTime.Now;
            // The following statment produces the first line of output
            //this line only occurs only once.
            Console.WriteLine("The static constructor is sets the global start time to {0}",globalStartTime.ToLongTimeString());
          
        }

        // declared an instance construct that takes one argument

        public Bus(int routenum)
        {
            RouteNumber = routenum;
            Console.WriteLine("Bus {0} is created ",RouteNumber);

        }

        //instance method
        public void Drive()
        {
            TimeSpan elapsedTime = DateTime.Now - globalStartTime;
            Console.WriteLine("{0} is starting it's Route {1:N2} mintues after global Start Time {2}.",this.RouteNumber,elapsedTime.TotalMilliseconds,globalStartTime.ToShortTimeString());
        }


        static void Main(string[] args)
        {
            // the creation of this object or instance activates the static constructor 
            Bus bus1 = new Bus(72);


            //creating a second bus. the static constructor will not be fired this time.
            Bus bus2 = new Bus(117);

            //send the bus on their way
            bus1.Drive();
            bus2.Drive();
            Console.WriteLine("Press and key to Create.");
            Console.ReadKey();

        }
    }
}
