using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureSamples
{
    public class Sort_Bubble
    {
        public static void Main()
        {
            print();
        }
        public static void print()
        {
            int i, j, no, temp;
            Console.WriteLine("Enter No of elements : ");
            no = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[no];
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Data {0} : ", (i + 1));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nBefore Sorting : ");
            foreach (int s in arr)
            {
                Console.Write(s);
            }
            for (i = 0; i < arr.Length - 1; i++)
            {
                for (j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                      
                    }
                    
                }
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("\nAfter Sorting : ");
            foreach (int s in arr)
            {
                Console.Write(" " + s);
            }
        }
    }
}
