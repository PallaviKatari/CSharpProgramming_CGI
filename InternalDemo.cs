using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    public class InternalDemo
    {
        public int a ;
        public int b;
        public int add()
        {
            //a = 10;
           // b = 20;
            return a + b;

        }
        public static void Main()
        {
            InternalDemo demo = new InternalDemo();
            int sum = demo.add();
            Console.WriteLine(sum);

        }
    }
}
