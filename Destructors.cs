using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    public class Trainees:IDisposable
    {
        public Trainees()
        {
            Console.WriteLine("Default Constructor");
        }
        /// <summary>
        /// Dispose method implemented from IDisposable interface
        /// </summary>
        public void Dispose()
        {
            Console.WriteLine("Resources are set free");
        }
        /// <summary>
        /// Destructors- deallocate the memory
        /// one destructor
        /// prefixed with ~tilde symbol
        /// no return type nor access specifiers
        /// Garbage Collection - free the memory
        /// Finalize() and Dispose() - files,database connection,service or any third party resources
        /// </summary>
        ~Trainees()
        {
            Console.WriteLine("Destructor Called");

        }

        //protected override void Finalize()
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }
        //}
    }

    internal class Destructors
    {
        public static void Main()
        {
            Trainees trainees=new Trainees();
            trainees.Dispose();

        }
    }
}
