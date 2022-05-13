using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// LOOPING - ITERATIVE PROCESS
    /// 1. ENTRY CONTROLLED - for,while
    /// 2. EXIT CONTROLLED - do-while
    /// foreach - readonly loop
    /// </summary>
    internal class Looping
    {
        /// <summary>
        /// Looping Examples
        /// </summary>
        public static void Main()
        {
            //FOR LOOP
            int n;
            int i;
            int sum=0;
            Console.WriteLine("Enter the value of n");
            n=Convert.ToInt32(Console.ReadLine()); // 7
            //++ increment operator
            for(i=1;i<=n;i++) //1<7 2<7 3<7 4<7 5<7 6<7 7<7
            {
                sum += i; //0+1+2+3=6+4=10+5=15+6=21+7
                Console.WriteLine(sum); // 1 3 6 10 15 21 28

            }
            Console.WriteLine("Sum is:{0}", sum); //21

            //WHILE LOOP
            Console.WriteLine("WHILE");
            int j = 10;
            while(j<5) //0<5 1<5 2<5 3<5 4<5 5<5
            {
                Console.WriteLine("The value is:{0}", j); //0 1 2 3 4
                j++; //1 2 3 4 5
            }

            //DO-WHILE LOOP
            Console.WriteLine("DO-WHILE");
            int k = 10;
            do
            {
                Console.WriteLine("The value is:{0}", k);
                k++;
            }while(k<5);

            //foreach
            Console.WriteLine("FOREACH");
            string course = "CSHARP";
            foreach(char c in course)
            {
                Console.WriteLine(c);
                //break and continue
                //break;
                //continue;
                if(c=='A')
                {
                    //break;
                    continue;
                }
                Console.WriteLine("Hello");
            }

        }
    }
}
