using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// Array - Collection of values of similar datatype
    /// ->1-D
    /// ->2-D
    /// ->MULTI-D
    /// ->JAGGED ARRAY
    /// </summary>
    internal class Arrays
    {
        public static void Main()
        {
            //SingleDimarray();
            //SingleDimarray1();
            //Arrays2D();
            JaggedArray();
        }

        //1-D ARRAY
        //rows/columns
        public static void SingleDimarray()
        {
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] numbers2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            
            //foreach loop
            Console.WriteLine("numbers1 array");
            foreach(int i in numbers1)
            {
                //row
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("numbers2 array");
            foreach (int j in numbers2)
            {
                //column
                Console.WriteLine(j);
            }

            Console.WriteLine("*********************");
            int[] numbers3 = new int[8] { 3, 28, 36,12,99,45,25,77 };
            Array.Sort(numbers3);
            Console.WriteLine("Sorted Array in Ascending order");
            foreach(int k in numbers3)
            {
                Console.WriteLine(k);
            }
            Array.Reverse(numbers3);
            Console.WriteLine("Sorted Array in Descending order");
            foreach (int k1 in numbers3)
            {
                Console.WriteLine(k1);
            }
            Console.WriteLine("Array Methods");
            Console.WriteLine(numbers3.Length);
            Console.WriteLine(numbers3.Min());
            Console.WriteLine(numbers3.Max());
            Console.WriteLine(numbers3.Average());
            Console.WriteLine(numbers3.Sum());
            Console.WriteLine("Math Functions");
            Console.WriteLine(Math.Abs(-10));
            Console.WriteLine(Math.Cos(1));
            Console.WriteLine(Math.Sin(1));
            Console.WriteLine(Math.Sqrt(16));
            Console.WriteLine(Math.Floor(4.8));
            Console.WriteLine(Math.Ceiling(4.8));
            Console.WriteLine(Math.Round(4.5));
            Console.WriteLine(Math.Pow(2, 2));
        }
        //1-D ARRAY - runtime values
        //rows/columns
        public static void SingleDimarray1()
        {
            Console.WriteLine("1 D ARRAY USING RUNTIME VALUES");
            int size;
            Console.WriteLine("Enter the size of the array"); //7
            size =Convert.ToInt32(Console.ReadLine());
            int[] arrays=new int[size]; // int[] arrays=new int[7];
            //Get input for the array
            for(int a=0;a<arrays.Length;a++)
            {
                Console.WriteLine("Enter the value of {0} array", (a + 1));
                arrays[a]=Convert.ToInt32(Console.ReadLine());
            }
            //Display the elements in the array
            Console.WriteLine("Elements in the array");
            foreach(int a1 in arrays)
            {
                Console.WriteLine(a1);
            }
            Console.WriteLine("Sum of the elements in the array");
            Console.WriteLine(arrays.Sum());
        }

        //2-D ARRAY - ROWS AND COLUMNS
        public static void Arrays2D()
        {
            int[,] arrays = new int[2, 3]
            {
                {1,2,3},
                {4,5,6}
            };
            Console.WriteLine("Elements in the 2D array");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(arrays[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //JAGGED ARRAY
        //Array of Arrays
        public static void JaggedArray()
        {
            int[][] jarray = new int[3][]
            {
                new int[3]{1,2,3},
                new int[5]{4,5,5,4,5},
                new int[7]{5,6,6,1,2,3,4},
            };
            Console.WriteLine("Elements in the array");
            for(int i=0;i<jarray.Length;i++)
            {
                for(int j=0;j<(jarray[i]).Length;j++)
                {
                    Console.Write(jarray[i][j]+"\t");
                }
                Console.WriteLine();
            }

        }

    }
}
