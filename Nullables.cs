using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// C# 2.0 - Nullables
    /// Value type - int,char,float,double,boolean
    /// null is assigned ->error
    /// </summary>
    internal class Nullables
    {
        public static void Main()
        {
            int? a = null;
            //Generic class
            Nullable<int> num = null;
            bool? b=null;
            Console.WriteLine($"int:{a}");
            Console.WriteLine($"Generic int:{num}");
            Console.WriteLine($"Boolean:{b}");

            //NULL COALESCING OPERATOR ??
            int? i=100;
            int? j = 10;
            int? k;
            k = i ?? j;
            Console.WriteLine($"k is {k}");

        }
    }
}
