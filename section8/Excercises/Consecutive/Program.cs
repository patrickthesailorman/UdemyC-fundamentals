using System;

namespace Consecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();
            var numbers = input.Split('-');


            // if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
        }
    }
}
