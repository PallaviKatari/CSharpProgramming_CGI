using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// CONSTRUCTORS - Special methods
    /// Same as the class name
    /// no return type
    /// automatically called/initiated
    /// Constructor Overloading
    /// </summary>
    internal class Constructors
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Constructors()
        {
            Console.WriteLine("I AM A DEFAULT CONSTRUCTOR");

        }
        /// <summary>
        /// Constructor with 1 parameter
        /// </summary>
        /// <param name="a"></param>
        public Constructors(int a)
        {
            Console.WriteLine($"Sum is:{a+a}");
        }
        public static void Main()
        {
            Constructors c=new Constructors();//default constructor is automatically called/initiated
            Constructors c1 = new Constructors(10);
        }
            
    }
}
