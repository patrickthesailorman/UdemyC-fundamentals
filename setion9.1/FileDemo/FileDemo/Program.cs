using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Copy(@"c:\temp\myFile.jpg", @"d:\temp\myFile.jpg", true);
        }
    }
}
