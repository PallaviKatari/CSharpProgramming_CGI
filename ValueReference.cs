using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    internal class ValueReference
    {
        /// <summary>
        /// Swapping using Pass by Value and Reference
        /// </summary>
        public static void Main()
        {
            int x = 10;
            int y = 20;
            Console.WriteLine($"Before Swapping: x is {x} and y is {y}");
            //Swap(x, y); //Pass by value - x and y - > own memory/address ->1004,1008
            Swap(ref x,ref y);//1004,1008
            Console.WriteLine($"After Swapping: x is {x} and y is {y}");

        }
        /// <summary>
        /// Swapping using Pass by Value and Reference
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        //public static void Swap(int num1,int num2) // num1 and num2 ->address -> 1010,1014
        public static void Swap(ref int num1, ref int num2)//x-1004-num1,y-1008-num2
        {
            Console.WriteLine($"Before Swapping: Num1 is {num1} and Num2 is {num2}");
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After Swapping: Num1 is {num1} and Num2 is {num2}");
        }
    }
}
