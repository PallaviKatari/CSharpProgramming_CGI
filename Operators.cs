using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// OPERATORS CONCEPTS
    /// </summary>
    internal class Operators
    {
        /// <summary>
        /// TYPES OF OPERATORS
        /// Arithmetic(+,-,*,/,%),Arithmetic assignment,Increment/Decrement,Relational,Logical,Bitwise
        /// </summary>
        public static void Main()
        {
            //Arithmetic and Arithmetic assignment
            int a;
            int b;
            int c;
            //Input during runtime
            //string-default
            Console.WriteLine("Enter the value of a");//10
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");//20
            b = Convert.ToInt32(Console.ReadLine());
            c = a * b;
            Console.WriteLine($"Product is:{c}");//200
            a+=b;//a=a+b;(+=,-=,*=,/=,%=)
            Console.WriteLine($"Sum is:{a}");//30

        }

    }
}
