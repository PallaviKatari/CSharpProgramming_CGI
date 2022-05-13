using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    internal class MethodsWithParameters
    {
        /// <summary>
        /// PARAMETERIZED METHODS
        /// </summary>
        public static void Main()
        {
            add(10, 20);
            int result = sub(100, 20);
            Console.WriteLine(result);
            int[] num = { 2, 4, 6, 8 };
            ParamsArray(1, 2, 3, 4, 5, 6, 7);
            ParamsArray(1, 2, 3);
            ParamsArray(1, 2, 3, 4, 5);
            ParamsArray(num);

        }
        /// <summary>
        /// add method with void return type
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void add(int a,int b)
        {
            int c=a+b;
            Console.WriteLine($"The sum is:{c}");
        }
        /// <summary>
        /// sub method with int return type
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>

        public static int sub(int a,int b)
        {
            return a - b;

        }
        /// <summary>
        /// params array - not sure of number of how many parameters passed to your calling method
        /// </summary>
        /// <param name="numbers"></param>

        public static void ParamsArray(params int[] numbers)
        {
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("********************");

        }
    }
}
