using System;

namespace InvalidList
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
            Console.WriteLine("Enter 5 numbers separated by commas: ");
                var [] numbers = Console.ReadLine();
                // if less than 5 numbers
                if (numbers != 5)
                {
                    Console.WriteLine("Invalid List! Pease try again.");
                }
                else if (var num in numbers == numbers -1)
                {
                    Console.WriteLine("Invalid List! Pease try again.");
                }
                else 
                {
                    numbers.Sort();
                    // display 3 smallest numbers
                    Console.WriteLine(numbers[0], numbers[1], numbers[2], );
                }

        }
    }
}
