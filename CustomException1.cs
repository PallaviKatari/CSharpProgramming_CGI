using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// User-defined exception to validate Name field
    /// </summary>
    public class CheckNameException:ApplicationException
    {
        public CheckNameException(string message):base(String.Format("Invalid name:{0}",message))
        {

        }
    }
    /// <summary>
    /// Student class with Name property
    /// </summary>
    public class Students
    {
        /// <summary>
        /// Property
        /// </summary>
        public string Name { get; set; }

    }
    internal class CustomException1
    {
        public static void Main()
        {
            try
            {
                Students students = new Students();
                students.Name = "John123";
                ValidateName(students);
                Console.WriteLine($"Name is:{students.Name}");
            }catch(CheckNameException e)
            {
                Console.WriteLine(e.Message);
            }


        }
        public static void ValidateName(Students s)
        {
            Regex regex = new Regex("^[A-Z][a-z]+$");
            if(!regex.IsMatch(s.Name))
                throw new CheckNameException(s.Name);
        }
    }
}
