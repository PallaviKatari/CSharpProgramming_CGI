using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    internal class StringFunctionsImportant
    {
        public static void Main()
        {
            string name = "John Johnny";
            Console.WriteLine(name.IndexOf("o"));
            Console.WriteLine(name.LastIndexOf("o"));
            Console.WriteLine(name.Substring(5));
            Console.WriteLine(name.Substring(5,4));

            //Loop 1
            //for(int i=0;i<5;i+1) // will not compile
            //{
            //    Console.WriteLine(i);
            //}

            //Loop 2
            //int i;
            //while(i=5)>=5) // will not compile
            //{
            //    Console.WriteLine(i);
            //}

        
        }
    }
}
