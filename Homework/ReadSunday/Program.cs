using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadSunday
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            try
            {
                //pass the file and the file name to the streamreader constructor
                StreamReader Sr = new StreamReader(@"E:\\COMP123\\WriteSunday.txt");

                //read the first line of text
                line = Sr.ReadLine();

                //contiune to read until you reach the end of file
                while (line != null)
                {
                    //write the first line to the console
                    Console.WriteLine(line);
                    //read the next line
                    line = Sr.ReadLine();
                }
                Sr.Close();
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:" + e.Message);
            }
            finally
            {
                Console.WriteLine("now Executing the final block");
                Console.ReadKey();
            }
        }
    }
}
