using System;

namespace MaxNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            var second = Convert.ToInt32(Console.ReadLine());

            var max = (first > second) ? first : second;
                Console.WriteLine(max);
        }
    }
}
