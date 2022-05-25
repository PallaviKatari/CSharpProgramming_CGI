using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    // STEP 1
    //------------
    /// <summary>
    /// Generics-Class,Method,property,constructor,variable etc can be of generic type
    /// </summary>
    //internal class Generics
    //{
    //    //How and Why Generics were introduced
    //    public static void Main()
    //    {

    //        bool result = Generics1.AreEqual(10,"Hello"); //value types

    //        if(result)
    //        {
    //            Console.WriteLine("EQUAL");
    //        }
    //        else
    //        {
    //            Console.WriteLine("NOT EQUAL");
    //        }
    //    }       
    //}
    ///// <summary>
    ///// LIMITATIONS-object-not type specific,poor performance-boxing and unboxing
    ///// </summary>
    //public class Generics1
    //{
    //    public static bool AreEqual(object a, object b)//reference type
    //    {
    //        //Console.WriteLine(a);
    //        //Console.WriteLine(b);
    //        //return a == b;
    //        return a.Equals(b);
    //    }
    //}

    //STEP 2
    //------------------------
    //Above limitation of the code is overcome by using the METHOD OVERLOADING
    //LIMITATION IN METHOD OVERLOADING-REPEATATION OF CODE FOR THE SAME LOGIC
    //internal class Generics
    //{
    //    public static void Main()
    //    {
    //       // bool result = Generics1.AreEqual(10, 10);
    //        bool result1 = Generics1.AreEqual("Hello", "Hello");
    //        if (result1)
    //        {
    //            Console.WriteLine("EQUAL");
    //        }
    //        else
    //        {
    //            Console.WriteLine("NOT EQUAL");
    //        }

    //    }
    //}
    //public class Generics1
    //{
    //    public static bool AreEqual(int a, int b)
    //    {

    //        return a.Equals(b);
    //    }
    //    public static bool AreEqual(string a, string b)
    //    {

    //        return a.Equals(b);
    //    }
    //}

    //STEP 3- TO OVERCOME THE LIMITATION OF METHOD OVERLOADING->GENERICS WERE INTRODUCED
    //internal class Generics
    //{
    //    public static void Main()
    //    {
    //        bool result = Generics1.AreEqual<int>(10, 10);
    //        bool result1 = Generics1.AreEqual<string>("Hello","Hello1");
    //        bool result2 = Generics1.AreEqual<double>(1.23,1.234);
    //        Generics1.Add<int, double>(10, 1.23);
    //        Generics1.Add<int, string>(10, "John");
    //        if (result2)
    //        {
    //            Console.WriteLine("EQUAL");
    //        }
    //        else
    //        {
    //            Console.WriteLine("NOT EQUAL");
    //        }

    //    }
    //}
    //public class Generics1
    //{
    //    public static bool AreEqual<T>(T a,T b)
    //    {
    //        return a.Equals(b);
    //    }

    //    public static void Add<T,T1>(T a, T1 b)
    //    { 
    //        Console.WriteLine($"Values are:{a} and {b}");
    //    }
    //}

    //Generics for various concepts in C#
    public class Generics1<T>
    {
        /// <summary>
        /// Generic variable
        /// </summary>
        private T ID;
        /// <summary>
        /// Generic Constructor
        /// </summary>
        /// <param name="id"></param>
        public Generics1(T uid)
        {
            Console.WriteLine("USERID is:{0}",uid);
        }
        /// <summary>
        /// Generic Method
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>

        public T Display(T msg)
        {
            Console.WriteLine("Employee id is:{0}",ID);
            Console.WriteLine(typeof(T).ToString());
            return msg;
        }
        /// <summary>
        /// Generic Property
        /// </summary>
        public T EID 
        {
            get { return ID; }
            set { ID = value; }
        }

    }
    public class Generics
    {
        public static void Main()
        {
            //Passing int as the type
            Generics1<int> generics1 = new Generics1<int>(10);
            generics1.EID = 100;
            int res=generics1.Display(1);
            Console.WriteLine("Message is:{0}", res);
            Console.WriteLine("***********************************");
            //Passing string as the type
            Generics1<string> generics2 = new Generics1<string>("U10");
            generics2.EID = "E100";
            string res1 = generics2.Display("M1");
            Console.WriteLine("Message is:{0}", res1);


        }
    }
}
