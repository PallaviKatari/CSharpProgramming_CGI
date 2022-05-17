using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// Abstraction
    /// Multiple inheritance(classes) - Multiple interfaces can be implemented(interfaces)
    /// interface keyword
    /// Interfaces - no variables
    /// Properties and methods
    /// Interface-Security
    /// </summary>
    
    //interface IEmployee
    interface IEmployee
    {
        /// <summary>
        /// Properties
        /// </summary>
        string Name { get; set; }
        int ID { get; set; }
        /// <summary>
        /// Method declaration
        /// </summary>
        //void EmployeeDetails();
        void Details();
    }
    /// <summary>
    /// Idepartment interface
    /// </summary>
    interface IDepartment
    {
        /// <summary>
        /// Properties
        /// </summary>
        int DID { get; set; }   
        string DName { get; set; }
        /// <summary>
        /// Method Declaration
        /// </summary>
         
        //void DepartmentDetails();
        void Details();
    }

    internal class EmployeeRecords:IEmployee, IDepartment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DID { get; set; }
        public string DName { get; set; }
        
        void IEmployee.Details()
        {
            Console.WriteLine($"ID is:{ID} and Name is:{Name}");
        }
        void IDepartment.Details()
        {
            Console.WriteLine($"DID is:{DID} and DName is:{DName}");
        }
    }
    internal class Interfaces
    {
        public static void Main()
        {
            //EmployeeRecords records = new EmployeeRecords();    
            //records.ID = 1;
            //records.Name = "John";
            //records.DID = 10;
            //records.DName = "HR";
            //records.EmployeeDetails();
            //records.DepartmentDetails();

            //Base->Derived
            IEmployee employee = new EmployeeRecords();
            employee.ID = 1;
            employee.Name = "John";
            employee.Details();
            IDepartment department=new EmployeeRecords();
            department.DID = 100;
            department.DName = "HR";
            department.Details();

        }
    }
}
