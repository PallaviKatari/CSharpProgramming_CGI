using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    internal class PassByOut
    {
        public static void Main()
        {
            int a,b;
            int sum = add(10, 20);
            Console.WriteLine(sum);
            GetValues(out a, out b);
            Console.WriteLine($"a is:{a} and b is:{b}");

        }
        /// <summary>
        /// Usage of return back a value in the form of int using return keyword
        /// return keyword-can return only a single value
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int add(int a,int b)
            { return a + b; }
        /// <summary>
        /// return back more than one value using out keyword
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>

        public static void GetValues(out int x,out int y)
        {
            Console.WriteLine("Enter the value of x and y");
            x=Convert.ToInt32(Console.ReadLine());
            y=Convert.ToInt32(Console.ReadLine());  
        }
    }
}
