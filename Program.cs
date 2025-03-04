using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
 
namespace File_File_Info

{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\bikram\Desktop\file.txt";

            File.Copy(@"C:\Users\bikram\Desktop\file.txt", @"C:\Users\bikram\Desktop\file1.txt", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
        }    
    }
}
