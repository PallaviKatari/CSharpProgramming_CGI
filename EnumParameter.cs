using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// Pass enum as a parameter to the method
    /// </summary>
    internal class EnumParameter
    {
        public enum vote
        {
            minor =17 ,
            major = 18
        }
        /// <summary>
        /// Passing an enum as a parameter
        /// </summary>
        /// <param name="v"></param>
        public static void eligible(vote v)
        {
            if((int)v<=17)
            {
                Console.WriteLine("Cannot Vote");
            }
            else
            {
                Console.WriteLine("Can Vote");
            }
        }
        public static void Main()
        {
            eligible(vote.minor);
            eligible(vote.major);

        }

    }
}
