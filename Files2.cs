using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// Properties and Methods in Files
    /// Retrieve Directories and files
    /// </summary>
    internal class Files2
    {
        public static void Main()
        {
            //Creates a new file, writes the specified string to the file,
            //and then closes the file. If the 
            //target file already exists, it is overwritten
            //File.WriteAllText(@"E:\Demo.txt", "Files WriteAllText Method\n");

            //File.AppendAllText(@"E:\Demo.txt", "Files AppendAllText Method");
            //string contents = File.ReadAllText(@"E:\Demo.txt");
            //Console.WriteLine(contents);

            //File.Delete(@"E:\ExampleNew.txt");

            //foreach(string file in Directory.GetFiles(@"E:\CG-VAK\WEB UI\htmlcssjsjqbootstrap\HTML\SESSION 1"))
            //{
            //    Console.WriteLine(file);
            //}
            //Console.WriteLine("**********************************************");

            //foreach (string file1 in Directory.GetDirectories(@"E:\"))
            //{
            //    Console.WriteLine(file1);
            //}

            FileInfo path = new FileInfo(@"E:\Trainees.txt");
            Console.WriteLine(path.FullName);
            Console.WriteLine(path.Extension);
            Console.WriteLine(path.Name);
            Console.WriteLine(path.CreationTime);
            Console.WriteLine(path.LastAccessTime);
            Console.WriteLine(path.LastWriteTime);
            Console.WriteLine(path.Length);
        }
    }
}
