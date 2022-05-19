using System;
using System.Collections.Generic;
using System.Linq;
//Serialize and Deserialize
using System.Runtime.Serialization; //IFormatter
using System.Runtime.Serialization.Formatters.Binary; //BinaryFormatter
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    /// <summary>
    /// Serialize and Deserialize the contents in the file
   [Serializable]
    internal class Files3
    {
        public int EmpID;
        public string EmpName;
        public string Designation;
      
        public static void Main()
        {
            Files3 files3 = new Files3();
            files3.EmpID = 100;
            files3.EmpName = "John";
            files3.Designation = "HR";
            //Base->Derived
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream(@"E:\SerDeSer.txt", FileMode.Create, FileAccess.ReadWrite);
            //Serialize->BinaryFormatter->implemented from IFormatter
            formatter.Serialize(stream, files3);
            stream.Close();
            //Deserialize
            stream = new FileStream(@"E:\SerDeSer.txt", FileMode.Open, FileAccess.ReadWrite);
            //(Files3)-Typecasting the content into Files3 instance/object
            Files3 f3=(Files3)formatter.Deserialize(stream);

            Console.WriteLine(f3.EmpID);
            Console.WriteLine(f3.EmpName);
            Console.WriteLine(f3.Designation);




        }
    }
}
