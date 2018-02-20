using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempCon
{
    public static class TempCon
    {
        public static double CelToFah(string tempCel)
        {
            double cel = double.Parse(tempCel);
            double fah = (cel * 9 / 5) + 32;
            return fah;
        }


        public static double FahToCel(string tempFah)
        {
            double fah = double.Parse(tempFah);
            double cel = (fah -32) * 5/9;
            return cel;
        }


        static void Main(string[] args)
        {
            /*TempCon TC = new TempCon();*/ //public  double CelToFah(string tempCel) will make it work be removing static 

            Console.WriteLine("Please Select Your option (Enter 1 or 2)");
            Console.WriteLine("1.From Celsius to Fahrenheit.");
            Console.WriteLine("2.From Fahrengeit to Celsius.");

            string choice = Console.ReadLine();

            double f, c = 0;

            switch (choice)
            {
                case "1":
                    Console.Write("Please Enter the celsius Temperature");
                    f = CelToFah(Console.ReadLine());
                    Console.WriteLine("The Temperture in Fahrenheit is {0:f2}",f);

                    break;

                case "2":
                    Console.Write("Please Enter the Fahrenheit Temperature");
                    c = FahToCel(Console.ReadLine());
                    Console.WriteLine("The Temperture in Celsuis is {0:f2}", c);

                    break;


                    default:
                    Console.WriteLine("Please select Your Choice: ");
                    break;



            }
            Console.WriteLine("Please Enter any key to Quit");

            Console.ReadKey();



        }
    }
}
