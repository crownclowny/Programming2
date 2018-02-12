using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Employee
{
    //instance variables
    private int empid;
    private string empName;
    private double empSalary;
    private string empAddress;
    // Constructors
    public  Employee()
    {

    }
    public Employee(int empid)
    {
        this.empid = empid;
    }
    public  Employee(int empid, string empName)
    {
        this.empid = empid;
        this.empName = empName;

    }
    public  Employee( string empName, double empSalary)
    {
        
        this.empName = empName;
        this.empSalary = empSalary;
    }
    public Employee( string EmpAddress)
    {

     
        this.EmpAddress = empaddress;
    }


    //property
    public string empaddress
    { get; set; }

    // 3 Methods that set and get the values  


    public int Empid
    {
        set { this.empid = value; }
        get { return this.empid; }

    }
   
    public string EmpName
    {
        set { this.empName = value; }
        get {  return this.empName; }

    }
    
    public double EmpSalary
    {
        set { this.empSalary= value; }
        get { return this.empSalary; }
    }

    public string EmpAddress
    {
        set { this.EmpAddress = value; }
        get { return this.empAddress; }
    }



}






namespace employee
   
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please Enter Employee ID#");
            Convert.ToInt32(Console.ReadLine());
            //  
            // 
            Employee E = new Employee(300964840);
            Console.WriteLine("The employee number is: " + E.Empid);

            Employee E1 = new Employee("Diego Hernandez",14.25);
            Console.WriteLine("The employee name is " + E1.EmpName);
            Console.WriteLine("The employee salary per hour is: " + E1.EmpSalary);
            
            Console.WriteLine("The employee's Adress is: " + empAddress);
            

            Console.ReadKey();

        }
    }
}
