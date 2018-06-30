using System;

namespace InvalidList
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //var numbers = new int [5];
            while (true)
            {

                Console.WriteLine("Enter 5 numbers separated by commas: ");
                var input = Console.ReadLine();

                var numbers = input.Split(',');


                // if less than 5 numbers
                if (numbers.Length != 5)
                {
                    Console.WriteLine("Invalid List! Pease try again.");
                    continue;
                }
                else

                    Array.Sort(numbers);
                // display 3 smallest numbers
                for (var i = 0; i < 3; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
