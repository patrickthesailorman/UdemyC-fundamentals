using System;

namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a series of numbers separated by commas: ");
            var array = Console.ReadLine();
            var nums = array.Split(",");
            var max = Convert.ToInt32(nums[0]);

            foreach (var num in nums)
            {
                var number = Convert.ToInt32(num);
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine(max);
        }
    }
}
