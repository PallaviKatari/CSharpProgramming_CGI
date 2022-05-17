using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// Enumeration - assign constant names to integral values
    /// enum keyword
    /// value type datatypes
    /// </summary>
    internal class Enumeration
    {
        /// <summary>
        /// User-defined enum
        /// </summary>
        enum FrontEndTech
        {
            Angular,
            React,
            Vue,
            ElectronJS = 7,
            Next
        }
        public static void Main()
        {
            Console.WriteLine(FrontEndTech.Angular);
            int vue = (int)FrontEndTech.Vue;
            Console.WriteLine($"Integral value of Vue:{vue}");
            var electron = (FrontEndTech)7;
            Console.WriteLine($"Constant name with integral value 7 is {electron}");
            var next= (FrontEndTech)8;
            Console.WriteLine($"Constant name with integral value 8 is {next}");
        }
    }
}
