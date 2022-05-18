using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// Trainee class with Name property
    /// </summary>
    public class Trainee
    {
        public string Name { get; set; }
    }
    internal class Throw
    {
        public static void Main()
        {
            Trainee t = null;
            try
            {
                GetName(t);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// Pass an object/instance as a parameter
        /// </summary>
        /// <param name="trainee"></param>
        public static void GetName(Trainee trainee)
        {
            if (trainee == null)
                throw new ArgumentNullException("No trainee name found");
            Console.WriteLine(trainee.Name);
        }
    }
}
