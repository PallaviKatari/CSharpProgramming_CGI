using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// POLYMORPHISM - COMPILE TIME - METHOD OVERLOADING
    /// RULES - No of parameters,Type of parameters,Sequence of parameters
    /// </summary>
    internal class Overloading
    {
        public int a;
        public int b;
        /// <summary>
        /// Method with no parameters
        /// </summary>
        public void add()
        {
            a = 10;
            b = 20;
            a += b;
            Console.WriteLine($"No Parameters:{a}");
        }
        /// <summary>
        /// Method overloaded by one parameter of int
        /// </summary>
        /// <param name="x"></param>
        public void add(int x)
        {
            a = x;
            a += a;
            Console.WriteLine($"One Parameter of int:{a}");
        }
        /// <summary>
        /// Method overloaded by one parameter of double
        /// </summary>
        /// <param name="x"></param>
        public void add(double x)
        {
            a = (int)x;
            a += a;
            Console.WriteLine($"One Parameter of double:{a}");
        }
        /// <summary>
        /// 2 Parameters of int and double
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void add(int x,double y)
        {
            x += (int)y;
            Console.WriteLine($"2 Parameters of int and double:{x}");

        }
        /// <summary>
        /// 2 Parameters of double and int
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>

        public void add(double x, int y)
        {
            y+=(int)x;
            Console.WriteLine($"2 Parameters of double and int:{y}");

        }
        public static void Main()
        {
            Overloading overloading = new Overloading();
            overloading.add();
            overloading.add(10);
            overloading.add(20.0);
            overloading.add(10, 20.0);
            overloading.add(30.0, 20);
        }
    }
}
