﻿using System;
using System.Collections.Generic;

namespace getSmallest
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2};
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);


        }
        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "Count should be between one and the number of elements in the list.");
            
            var buffer = new List<int>(list):
            var smallests = new List<int>():

            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }
            return smallests;
        }
        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}
