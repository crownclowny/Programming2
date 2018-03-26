using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadSundayObj
{
    class Program
    {

        static void Main(string[] args)
        {
            const char DELIM = ',';
            const string FILENAME = "E:\\COMP123\\SunEmpData.txt";
            Employee emp = new ReadSundayObj.Employee();

            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            string recordIn;
            string[] fields;
            Console.WriteLine("\n{0,-5}{1,-12}{2,8}\n", "NUM", "NAME", "Salary");
            recordIn = reader.ReadLine();
            while (recordIn !=null)
            {
                fields = recordIn.Split(DELIM);
                emp.EmpNum = Convert.ToInt32(fields[0]);
                emp.Name = fields[1];
                emp.Salary = Convert.ToDouble(fields[2]);
                Console.WriteLine("{0,-5}{1,-12}{2,8}",emp.EmpNum,emp.Name,emp.Salary.ToString("C"));
                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
            Console.ReadKey();
        }
    }
    
}
