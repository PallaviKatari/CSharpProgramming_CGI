using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// STEP 1:Creating the class for user-defined exception
    /// </summary>
    internal class AttendanceException:ApplicationException
    {
        public AttendanceException(string message):base(message)
        {

        }

    }
    /// <summary>
    /// Implementing the user-defined exception class
    /// </summary>

    internal class CustomException
    {
        public static void Main()
        {
            int strength=0;
            try
            {
                Console.WriteLine("Enter the number of trainees present");
                strength =Convert.ToInt32(Console.ReadLine());
                if(strength < 37)
                {
                    throw new AttendanceException("Some are absent");
                    //Console.WriteLine("Some are absent");
                }
                else
                {
                    Console.WriteLine("All are present");
                }
            }catch(AttendanceException e)
            {
                Console.WriteLine(e.Message);
            }finally
            {
                Console.WriteLine($"Strength is:{strength}");
            }

        }
    }
}
