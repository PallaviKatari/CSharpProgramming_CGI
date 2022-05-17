using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// STRUCTURES - Value type datatypes - Collection of variables with different datatypes
    /// Methods and properties
    
    /// Class-Large app,Code reusability(Inheritance),
    /// protected,Constructors(default) and destructors,Reference type(heap memory)
    
    /// Structure-Small app,do not support inheritance and protected access specifier,
    /// Can have only parameterized constructors(no default constructors),Value type(Stack memory)
    /// </summary>
    
    struct CSharpBatch
    {
        //Variables
        public int TID;
        public string TName;
        /// <summary>
        /// Parametrized constructor for the structure
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public CSharpBatch(int id,string name)
        {
            TID = id;
            TName = name;
        }
        /// <summary>
        /// Runtime values
        /// </summary>

        public void GetDetails()
        {
            Console.WriteLine("Enter your ID and Name");
            TID=Convert.ToInt32(Console.ReadLine());
            TName=Console.ReadLine();
        }
        /// <summary>
        /// Display the values
        /// </summary>

        public void Display()
        {
            Console.WriteLine($"ID is {TID} and Name is {TName}");
        }

    }
    /// <summary>
    /// Accessing the structure from the class
    /// </summary>
    internal class Structures
    {
        public static void Main()
        {
            CSharpBatch batch = new CSharpBatch(10,"John");
            batch.Display();
            batch.GetDetails();
            batch.Display();
        }

    }
}
