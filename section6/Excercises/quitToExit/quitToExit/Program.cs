using System;

namespace quitToExit
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number or type 'quit' to exit");
                var input = Console.ReadLine();
                var display = new [](input);
                if (input.ToLower() == "quit")
                    break;
                else
                    continue;
            }
            Console.WriteLine(display);
        }
    }
}
