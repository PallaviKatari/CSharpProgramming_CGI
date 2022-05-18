using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// Working of multiple catch blocks
    /// </summary>
    internal class MultipleCatch
    {
        public static void Main()
        {
            IndexDemo();
            int[] num1 = { 2, 4, 6, 8, 10 };//5
            int[] num2 = { 2, 0, 0, 2 };//4
            for (int i = 0; i < num1.Length;i++)
            {
                try
                {
                    Console.WriteLine(num1[i]/num2[i]);
                }catch(DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void IndexDemo()
        {
            int[] numbers = { 1, 2, 3 };
            try
            {
                Console.WriteLine(numbers[3]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
