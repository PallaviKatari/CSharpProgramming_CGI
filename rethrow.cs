using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    internal class rethrow
    {
        public static void Main()
        {
            try
            {
                One();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public static void One()
        {
            try
            {
                Two();
            }catch(Exception)
            {
                throw;
            }

        }
        public static void Two()
        {
            int a = 10;
            int b = 0;
            try
            {
                a /= b;

            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }
    }
}
