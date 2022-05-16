using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// Encapsulation 
    /// Access Specifiers- private,public,internal,protected,protected internal
    /// </summary>
    internal class Encapsulation
    {
        public static void Main()
        {
            AccessSpecifiers accessSpecifiers = new AccessSpecifiers();
            accessSpecifiers.Id = 10;
            accessSpecifiers.display();
            Console.WriteLine($"ID is:{accessSpecifiers.Id}");

        }
    }
    /// <summary>
    /// PRIVATE ACCESS SPECIFIERS
    /// PROPERTIES - GET AND SET METHODS
    /// </summary>
    internal class AccessSpecifiers
    {
        //private variables
        private int id;
        //private string name;

        //Properties
        public int Id
        {
            get { return id; } //read
            set { id = value; } //write
        }

        public void display()
        {
            Console.WriteLine($"ID is:{id}");
        }

    }
}
