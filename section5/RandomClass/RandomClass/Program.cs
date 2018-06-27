using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            char[] buffer = new char[10];


            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine((char)('a' + random.Next(0, 26)));
                Console.WriteLine();
            }
           
        }
    }
}
