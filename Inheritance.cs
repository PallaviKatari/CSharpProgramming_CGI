using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// Inheritance-Code Reusability
    /// Types-Single,Multi-level,Hybrid,Hierarchial
    /// Multiple Inheritance-Not supported-instead Interfaces are used
    /// protected access specifier
    /// </summary>
    /// BASE CLASS 
    internal class Employee
    {
        protected int EID;
        protected string EName;
        protected int TDID;
        protected string TDName;
        protected void Display()
        {
            Console.WriteLine("BASE CLASS");
        }
    }
    /// <summary>
    /// Child Class - Department
    /// Single-level
    /// </summary>
    internal class Department:Employee
    {
        protected int DID;
        protected string DName;
        
    }
    /// <summary>
    /// Hierarchial Inheritance
    /// </summary>
    internal class TrainingDepartment : Employee
    {
        public void GetTDetails()
        {
            TDID = 101;
            TDName = "DOTNET";
            Console.WriteLine($"TDID is {TDID} and TDName is {TDName}");
        }

    }
    /// <summary>
    /// Multi-level inheritance
    /// </summary>

    internal class Admin:Department
    {
        public void GetEmployeeDetails()
        {
            EID = 100;
            EName = "John";
            DID = 10;
            DName = "Developer";
            Console.WriteLine($"Employee {EID}'s name is {EName}");
            Console.WriteLine($"{EName} is in {DName} Department");
        }

    }
    /// <summary>
    /// Accessing the base from derived class
    /// </summary>
    internal class Inheritance
    {
        public static void Main()
        {
            //Single-level
           // Department department = new Department();
           // department.GetEmployeeDetails();
           // department.Display();

           //Multi-level
            Admin admin = new Admin();
            admin.GetEmployeeDetails();

            //Hierarchial
            TrainingDepartment trainingDepartment = new TrainingDepartment();
            trainingDepartment.GetTDetails();
        }
    }
}
