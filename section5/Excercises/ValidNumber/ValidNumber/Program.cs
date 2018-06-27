using System;

namespace ValidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number between 1 and 10: ");
            var input = Convert.ToDouble(Console.ReadLine());

            var check = (input >= 1 && input <= 10) ? "Valid" : "Invalid";

            Console.WriteLine(check);
        }
    }
}
