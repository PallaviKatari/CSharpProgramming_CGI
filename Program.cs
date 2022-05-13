using System; //Basic Namespace
/// <summary>
/// Namespace-Collection of classes
/// </summary>
namespace CSharp
{
    /// <summary>
    /// class Basics has been created 
    /// </summary>
    public class Basics
    {
        /// <summary>
        /// Entry point of your program
        /// Functions - Methods
        /// </summary>
        public static void Main()
        {
            //Method to display a message
            Console.WriteLine("Welcome to CSHARP PROGRAMMING");

            //Datatypes and Variables
            //Data-information  datatype-type of information
            //Value Type - single value - int,float,double,char,bool
            //Reference Type - group of values - string

            //integer
            int a = 10;
            int b = 10;
            int c = a + b; //c=20
            int d = a - b; //d=0;
            // \n - newline
            Console.WriteLine("The sum is: " + c +"\n"+"The difference is: "+ d); //1st way
            //{0} - string formatting
            // \t - tabspace
            Console.WriteLine("The sum is:{0} \t The difference is:{1}", c,d); //2nd way
            //String Interpolation
            Console.WriteLine($"The sum is:{c} \n The difference is:{d}"); //3rd way

            //float and double
            float e = 3.14f; //7 digits after the decimal point
            double f = 3.14; //15 digits
            Console.WriteLine($"Float:{e} and Double:{f}");

            //char
            char g = 'A';
            Console.WriteLine($"The character is:{g}");

            //boolean
            bool h = true;
            Console.WriteLine($"Boolean value is:{h}");

            //string
            string s = "Welcome";
            string s1 = "Programming";
            Console.WriteLine($"Hello Trainees!!! {s} to CSharp {s1} ");

            //Type Conversion
            double num = 1.23; 
            Console.WriteLine($"num is:{num}"); //1.23
            int num1=(int)num;
            Console.WriteLine($"num1 is:{num1}"); //1
            Console.WriteLine("Convert int to char:{0}", Convert.ToChar(65));
            Console.WriteLine("Convert char to int:{0}", Convert.ToInt32(')'));

        }
    }
}
