using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureSamples
{
    class Search_Binary
    {
        public static void Main()
        {
            int[] a = new int[100];
            Console.WriteLine("Number of elements in the array ?");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Enter array elements ");
            Console.WriteLine("-----------------------");
            for (int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter Search element");
            Console.WriteLine("--------------------");
            string s3 = Console.ReadLine();
            int x2 = Int32.Parse(s3);
            int low = 0;
            int high = x - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (x2 < a[mid])
                    high = mid - 1;
                else if (x2 > a[mid])
                    low = mid + 1;
                else if (x2 == a[mid])
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Search successful");
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Element {0} found at location {1}\n", x2, mid + 1);
                    return;
                }
            }
            Console.WriteLine("Search unsuccessful");
        }
        
    }
}