using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// STRING AND STRINGBUILDER
    /// </summary>
    internal class Strings
    {
        /// <summary>
        /// STRINGS EXAMPLE
        /// </summary>
        public static void Main()
        {
            //strings - immutable - cannot change the value 
            //string - datatype 
            string name = "John"; //1004 - John 
            Console.WriteLine(name);
            name = "John Paul";// 1008 - John Paul
            Console.WriteLine(name);
            //String - class
            string c = "CSharp";
            String course = new String(c);
            Console.WriteLine(course);
            Console.WriteLine(c);
            //character array
            char[] designation = { 'H', 'R' };
            foreach(char d in designation)
            {
                Console.Write(d);
            }
            Console.WriteLine();

            //Escape Sequence characters
            // \n \t \\ \" \'
            Console.WriteLine("\'Welcome to \t \"CSharp\" Programming\'");
            Console.WriteLine("\\\\CSharp\\Strings");
            //Verbatim Strings - @
            Console.WriteLine(@"\\CSharp\Strings");
            Console.WriteLine(@"E:\Dotnet");

            //STRINGBUILDER - class - using System.Text;
            //Mutable - change the value of a variable which is stored in the same memory
            Console.WriteLine("STRINGBUILDER");
            StringBuilder sb = new StringBuilder("Welcome");
            Console.WriteLine(sb.ToString());
            sb.Append(" Trainees");
            Console.WriteLine(sb.ToString());
            sb.Insert(8, "back ");
            Console.WriteLine(sb.ToString());
            sb.Remove(8, 5);
            Console.WriteLine(sb.ToString());
            // COMMENT - CTRL+K+C
            // UNCOMMENT - CTRL+K+U

        }
    }
}
