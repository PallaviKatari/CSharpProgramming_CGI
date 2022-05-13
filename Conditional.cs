using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// CONTROL STATEMENTS
    /// 1. CONDITIONAL
    /// 2. LOOPING
    /// </summary>
    internal class Conditional
    {
        /// <summary>
        /// CONDITIONAL STATEMENTS - increment/decrement operators,relational,logical
        /// 1. simple if, if-else, else if, nested if
        /// 2. switch-case
        /// </summary>
        public static void Main()
        {
            //Greatest of 3 numbers
            int a;
            int b;
            int c;
            Console.WriteLine("Enter the value of a ,b and c");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            c=Convert.ToInt32(Console.ReadLine());
            //simple if, if-else, else if, nested if
            //> < >= <= realtional
            //&&-and  ||-or  logical 
            //if((a>b) && (a>c))
            //{
            //    Console.WriteLine("A IS THE GREATEST");
            //}
            if(a>b)
            {
                if(a>c)
                {
                    Console.WriteLine("A IS THE GREATEST");
                }
            }
            else if(b>c)
            {
                Console.WriteLine("B IS THE GREATEST");
            }
            else
            {
                Console.WriteLine("C IS THE GREATEST");
            }

            //SWITCH-CASE
            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();//default datatype is string
            switch(name)
            {
                case "John":Console.WriteLine("Success");
                            break;
                case "Peter":
                            Console.WriteLine("Success");
                            break;
                case "Paul":
                            Console.WriteLine("Success");
                            break;
                case "Sam":
                            Console.WriteLine("Success");
                            break;
                    default:Console.WriteLine("Failure");
                            break;

            }

        }
    }
}
