using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// Abstraction-Data Hiding-Abstract classes and Interfaces
    /// Abstract classes- abstract keyword,abstract methods(method declaration)
    /// non-abstract methods,cannot instantiate or create an object for the abstract class
    /// Abstract classes must be inherited and all the abstract methods must be implemented or method definition must be given             
    /// Method Overriding - Runtime polymorphism
    /// </summary>
    
    internal abstract class EB_Plan
    {
        protected double rate;
        protected int CID;
        protected string CName;

        public abstract void GetRate();
        public abstract void GetCustomerDetails();
        public void Calculate(double units)
        {
            Console.WriteLine($"EB Bill is:{units * rate}");
        }
    }
    /// <summary>
    /// Commercial inheriting EB_Plan
    /// </summary>

    internal class Commercial:EB_Plan
    {
        public override void GetRate()
        {
            rate = 10.00;
        }
        public override void GetCustomerDetails()
        {
            Console.WriteLine("Enter the customer details");
            CID=Convert.ToInt32(Console.ReadLine());
            CName=Console.ReadLine();
            Console.WriteLine($"Customer Details:{CID}={CName}");           
        }

    }
    /// <summary>
    /// Domestic inheriting EB_Plan
    /// </summary>
    internal class Domestic : EB_Plan
    {
        public override void GetRate()
        {
            rate = 5.00;
        }
        public override void GetCustomerDetails()
        {
            Console.WriteLine("Enter the customer details");
            CID = Convert.ToInt32(Console.ReadLine());
            CName = Console.ReadLine();
            Console.WriteLine($"Customer Details:{CID}={CName}");
        }

    }
    internal class Abstraction
    {
        public static void Main()
        {
            //Base->Derived
            EB_Plan eb;
            eb = new Commercial();
            eb.GetCustomerDetails();
            eb.GetRate();
            eb.Calculate(600.70);
            eb = new Domestic();
            eb.GetCustomerDetails();
            eb.GetRate();
            eb.Calculate(300.70);
        }
    }
}
