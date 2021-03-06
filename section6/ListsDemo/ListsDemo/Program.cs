﻿using System;

namespace ListsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };

            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers) 
            Console.WriteLine(number);

            numbers.IndexOf(1);
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count());

            // Console.WriteLine("Remove: " + numbers.Remove(1));

            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count());

        }
    }
}
