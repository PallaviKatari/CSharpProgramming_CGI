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
            print();
        }
        public static void print()
        {
            int i, no;
            Console.WriteLine("Enter No : ");
            no = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[no];

            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Data {0} : ", (i + 1));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter Data to Search :");
            int data = Convert.ToInt32(Console.ReadLine());
            int res = Search(arr, data);
            if (res != -1)
            {
                Console.WriteLine("Found at {0} Position ", res);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
        public static int Search(int[] arr, int target)
        {
            int min = 0, max = arr.Length - 1;

            while (min < max)
            {
                int mid = (min + max) / 2;
                if (target == arr[mid])
                {
                    return ++mid;
                }
                else if (target < arr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return 0;
        }
    }
}