using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    public interface IOne
    {
        public int one();
        public void two();
    }
    public class Sample :IOne
    {
        public int one()
        {
            return 1;

        }
        public void two()
        {

        }
    }
    public class HelloWorld
    {

        public static void Main()
        {
            Sample s = new Sample();
            s.one();
            s.two();
            Console.WriteLine("Hello World");
        }
    }

}
