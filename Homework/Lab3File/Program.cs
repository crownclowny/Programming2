using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3File
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
                StreamWriter SW = new StreamWriter("F:\\COMP123Lab3\\Lab3File.txt", true, Encoding.ASCII);
                //write numbers 1-10 on the same line
                for (x = 0; x < 1; x++)
                {
                    SW.Write(Console.ReadLine());
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
