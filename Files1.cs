using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// Files-FileStream-(StreamReader-StreamWriter)-helper classes
    /// Filestream - inherited from Stream class(abstract)
    /// </summary>
    internal class Files1
    {
        public static void Main()
        {
            FileInfo fileInfo = new FileInfo(@"E:\Trainees.txt");
            //StreamWriter
            //FileStream fs = fileInfo.Open(FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            //StreamReader
            //FileStream fs = fileInfo.Open(FileMode.Open,FileAccess.ReadWrite,FileShare.ReadWrite
            //Append Mode - FileAccess can be only Write
            FileStream fs = fileInfo.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite);

            //WRITE OPERATION
            StreamWriter sw = new StreamWriter(fs);//Trainees.txt
            try
            {
                sw.WriteLine("Welcome to Files StreamReader and StreamWriter Concepts");
            }
            catch (FileNotFoundException e)
            {
                Console.Write(e.ToString());
            }
            finally
            {
                sw.Close();
                fs.Close();
            }

            //READ OPERATION
            //StreamReader sr = new StreamReader(fs);//Trainees.txt
            //try
            //{
            //    string contents;
            //    contents=sr.ReadToEnd();
            //    Console.WriteLine(contents);
            //}catch(FileNotFoundException e)
            //{
            //    Console.WriteLine(e.Message);
            //}finally
            //{
            //    sr.Close();
            //    fs.Close();
            //}


        }
    }
}
