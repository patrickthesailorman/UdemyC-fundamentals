using System;
using System.IO;

namespace DirectoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            Console.WriteLine(file);
        }
    }
}
