using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SunFile1
{
    class Program
    {
        static void Main(string[] args)
        {
            // this write to a file
            Int64 x;
            try
            {
                // try block open the file
                StreamWriter SW = new StreamWriter("E:\\COMP123\\WriteSunday.txt", true, Encoding.ASCII);
                //write numbers 1-10 on the same line
                for (x = 0; x < 10; x++)
                {
                    SW.Write(x);
                }
                SW.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:" + e.Message);
            }
            finally
            {
                Console.WriteLine("Excecuting Finally block.");
                
            }
        }
    }
}
