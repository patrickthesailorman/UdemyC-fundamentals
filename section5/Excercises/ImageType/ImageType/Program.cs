using System;

namespace ImageType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter image Height: ");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter image width : ");
            var width = Convert.ToInt32(Console.ReadLine());

            if (height > width)
            {
                Console.WriteLine("It's a portrait!");
            }
            else
            {
                Console.WriteLine("It's a landscape!");
            }
        }
    }
}
