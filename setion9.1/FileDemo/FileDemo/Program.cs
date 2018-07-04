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

        }
    }
}
