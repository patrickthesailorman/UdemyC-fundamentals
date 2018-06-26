using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "John Smith";
            for (var i = 0; i < name.Length; i++) 
            {
                Console.WriteLine(name[i]);
            }

        }
    }
}
