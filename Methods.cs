using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// TYPES OF METHODS IN C#
    /// STATIC METHOD
    /// INSTANCE METHOD
    /// </summary>
    internal class Methods
    {
        //Call/Invoke the user-defined methods
        public static void Main()
        {
            //Call a static method
            StaticDemo();
            //Call an instance method
            //instance - object
            Methods methods=new Methods();
            methods.InstanceDemo();

            //Call a static method from another class
            //Methods1.StaticDemo1();
            //Call an instance method from another class
            //instance - object
            Methods1 methods1 = new Methods1();
            methods1.InstanceDemo1();
        }
        //STATIC METHOD
        public static void StaticDemo()
        {
            Console.WriteLine("I am a static method");
        }

        //INSTANCE METHOD
        public void InstanceDemo()
        {
            Console.WriteLine("I am an instance method");
        }

    }

    internal class Methods1
    {
        //STATIC METHOD
        public static void StaticDemo1()
        {
            Console.WriteLine("I am a static method1");
        }

        //INSTANCE METHOD
        public void InstanceDemo1()
        {
            StaticDemo1();
            Console.WriteLine("I am an instance method1");
        }

    }
}
