using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\temp\myFile.jpg", @"d:\temp\myFile.jpg", true);
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
