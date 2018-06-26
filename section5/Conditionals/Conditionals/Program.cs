using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;
             
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn and a beautiful season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's summer and a beautiful season.");
                    break;
                default:
                    Console.WriteLine("I don't understand that season.");
                    break;
            }
        }
    }
}
