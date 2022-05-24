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
            QueueDemo();
            SortedListDemo();   
            DictionaryDemo();
            HashtableDemo();
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
        /// <summary>
        /// Queue-Generic-ENQUEUE,DEQUEUE-FIFO
        /// </summary>

        public static void QueueDemo()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine("QUEUE");
            foreach(int q in queue)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine("*********************************");
            int first=queue.Dequeue();
            Console.WriteLine(first);
            Console.WriteLine("*********************************");
            foreach (int q in queue)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine("*********************************");
            int front=queue.Peek();
            Console.WriteLine(front);

        }
        /// <summary>
        /// SortedList-Generic-key/value-sort by default
        /// </summary>
        public static void SortedListDemo()
        {
            SortedList<string,string> list = new SortedList<string,string>();
            list.Add("C#001", "CSharp Programming");
            list.Add("J002", "Java Programming");
            list.Add("P003", "Python Programming");
            list.Add("A004", "ASP.NET MVC");
            Console.WriteLine("SORTED LIST");
            foreach(var sl in list)
            {
                Console.WriteLine(sl);
            }
            Console.WriteLine("*********************************");
        }
        /// <summary>
        /// Dictionary-key/value pair-Generic-type specific
        /// </summary>
        public static void DictionaryDemo()
        {
            try
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("in", "India");
                dict.Add("us", "United States");
                dict.Add("uk", "United Kingdom");
                Console.WriteLine("DICTIONARY");
                foreach (KeyValuePair<string, string> kvp in dict)
                {
                    Console.Write(kvp.Key.ToString() + " ");
                    Console.Write(kvp.Value.ToString());
                    Console.WriteLine();
                }
                Console.WriteLine(dict["sk"]);//raise an exception
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("*********************************");

        }
        /// <summary>
        /// Hashtable-Non-generic-key/value-not type specific
        /// </summary>
        public static void HashtableDemo()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "C#");
            hashtable.Add(2, "Java");
            hashtable.Add("in", "India");
            Console.WriteLine("HASHTABLE");
            //Interface
            ICollection key=hashtable.Keys;
            foreach(var contents in key)
            {
                Console.WriteLine(hashtable[contents]);
            }
            Console.WriteLine(hashtable[3]);

        }
    }
}
