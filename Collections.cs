using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// Collections-Class-dynamic memory allocation-store/retrieve data- operations/functions
    /// System.Collections;
    /// System.Collections.Generic;
    /// Collections-replace the data structure of an array
    /// ArrayList,List<>,SortedList<> etc
    /// </summary>
    internal class Collections
    {
        public static void Main()
        {

            ArrayListDemo();
            ListDemo();
            StackDemo();
        }
        /// <summary>
        /// 1. ArrayList-Sytem.Collections-non-generic-not type specific
        /// </summary>
        public static void ArrayListDemo()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2.25);
            arrayList.Add("Hello");
            arrayList.Add('N');
            arrayList.Add(true);
            arrayList.Add(false);
            arrayList.Add(1.23f);
            Console.WriteLine("ARRAYLIST");
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********************************");
            var res=arrayList.IndexOf(1);
            Console.WriteLine(res);
            Console.WriteLine("*********************************");
            arrayList.Remove("Hello");
            Console.WriteLine("*********************************");
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********************************");
            arrayList.RemoveAt(1);
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********************************");
            arrayList.Add(10);
            arrayList.Add("Last element");
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********************************");

        }
        /// <summary>
        /// List-System.Collections.Generic-Generic class-type specific
        /// </summary>
        public static void ListDemo()
        {
            List<int> vs = new List<int>();
            vs.Add(1);
            vs.Add(2);
            vs.Add(3);
            vs.Add(4);
            vs.Add(5);
            Console.WriteLine("List");
            foreach (int j in vs)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("*********************************");
            vs.Add(6);
            vs.Add(7);
            vs.Add(8);
            vs.Remove(1);
            foreach (int j in vs)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("*********************************");

        }
        /// <summary>
        /// Stack-LIFO-Generic stack-PUSH AND POP-type specific
        /// </summary>
        public static void StackDemo()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("Stack");
            foreach(int k in stack)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("*********************************");
            int last=stack.Pop();
            Console.WriteLine(last);
            Console.WriteLine("*********************************");
            foreach (int k in stack)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("*********************************");
            int top=stack.Peek();
            Console.WriteLine(top);
            Console.WriteLine("*********************************");
            int lastele=stack.ElementAt(0);
            Console.WriteLine(lastele);
            Console.WriteLine("*********************************");
            int first=stack.First();
            Console.WriteLine(first);
            Console.WriteLine("*********************************");
            int firstele=stack.ElementAt(1);
            Console.WriteLine(firstele);
            Console.WriteLine("*********************************");
        }
    }
}
