using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5Exceptions
{

    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {

        }
    }
    public class Temperature
    {
        int temperature;
        public Temperature(int temp)
        {
            try
            {
                temperature = temp;

                if (temperature == 0)
                {
                    throw (new TempIsZeroException("Err 4001: Zero temperature encountered during the construction of the object"));
                }
            }

            catch(TempIsZeroException e)
            {
                Console.Write(e);

            }

        }


    }
    class TestTemp
    {
        static void Main (string[] args)
        {
            Temperature temp1 = new Temperature(0);
            Console.ReadKey();
        }
    }


}
