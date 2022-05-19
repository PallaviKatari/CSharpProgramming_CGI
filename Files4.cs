using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// BinaryReader and BinaryWriter
    /// </summary>
    internal class Files4
    {
        public static string path = @"E:\BinaryDemo.txt";
        /// <summary>
        /// BinaryWriter
        /// </summary>
        public static void BinaryWriteDemo()
        {
            try
            {
                if(File.Exists(path))
                {
                    File.Delete(path);
                }
                FileStream fs = new FileStream(path,FileMode.Create,FileAccess.Write,FileShare.ReadWrite);
                //using->automatically free the resources / close the file
                using (BinaryWriter binaryWriter = new BinaryWriter(fs))
                {
                    binaryWriter.Write(123);
                    binaryWriter.Write("Hello");
                    binaryWriter.Write('A');
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// BinaryReader
        /// </summary>
        public static void BinaryReadDemo()
        {
            try
            {
                
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                //using->automatically free the resources / close the file
                using (BinaryReader binaryReader = new BinaryReader(fs))
                {
                    Console.WriteLine(binaryReader.ReadInt32());
                    Console.WriteLine(binaryReader.ReadString());
                    Console.WriteLine(binaryReader.ReadChar());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Main()
        {
            BinaryWriteDemo();
            BinaryReadDemo();
        }

    }
}
