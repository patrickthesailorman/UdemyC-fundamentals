using System;

namespace fiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[5];
            var count = 0;

            while (count != 5)
            {
                Console.WriteLine("enter 5 unique numbers: ");
                var input = Console.ReadLine();
                var num = Convert.ToInt32(input);
                for (int i = 0; i < input.Length; i++)
                {
                    if (Array.IndexOf(numbers, num) == -1)
                    {
                        numbers.Add(num);
                        count++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("error: no repeat numbers. Please try again");
                    }
                }
            }
            Array.Sort(numbers);
            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
