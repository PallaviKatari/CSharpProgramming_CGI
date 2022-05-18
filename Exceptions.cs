using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// Error - Syntax error,Logical,Runtime(Exception handling)
    /// Exception Handling-try,catch,throw,finally
    /// Exception - Base class
    /// DivideByZeroException,ArithmeticException etc
    /// </summary>
    internal class Exceptions
    {
        public static void Main()
        {
            Div(); 
        }

        public static void Div()
        {
            int a = 10;
            int b = 0;
            try
            {
                a /= b;

            }
            catch (DivideByZeroException e)
            {
                //Console.WriteLine(e.ToString());
                //PROPERTIES 
                //Message,InnerException,Source,StackTrace,TargetSite
                Console.WriteLine(e.TargetSite);

            }
            //database connectivity,files etc
            finally
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("HELLO");
        }
       
            
    }
}
