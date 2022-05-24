using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureSamples
{
    public class Search_Linear
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
            for (int i = 0; i < arr.Length; i++)
            {
                if (target == arr[i])
                {
                    return (i + 1);
                }
            }
            return -1;
        }
    }
}
