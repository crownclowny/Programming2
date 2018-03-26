using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SundayWriteObj
{
    class Program
    {
        static void Main(string[] args)
        {
            const int END = 999;
            const string DELIM = ",";
            const string FILENAME = "E:\\COMP123\\SunEmpData.txt";


            Employee emp = new Employee();
            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            Console.Write("Enter  Employee Nnumber or " + END+"to quit>>");
            emp.EmpNum = Convert.ToInt32(Console.ReadLine());

            while (emp.EmpNum != END)
            {
                Console.Write("Enter Employee Name>>");
                emp.Name = Console.ReadLine();
                Console.Write("Enter Employee Salary>>");
                emp.Salary = Convert.ToDouble(Console.ReadLine());

                writer.WriteLine(emp.EmpNum + DELIM + emp.Name + DELIM + emp.Salary);
                Console.Write("Enter Another Employee Nnumber or " + END + "to quit>>");
                emp.EmpNum = Convert.ToInt32(Console.ReadLine());

                

            }
            writer.Close();
            outFile.Close();
        }
    }
}
