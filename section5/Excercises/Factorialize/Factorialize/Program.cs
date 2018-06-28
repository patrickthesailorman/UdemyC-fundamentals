﻿using System;

namespace Factorialize
{
    class Program
    {
        static void Main(string[] args)
        {
            {   
            Console.WriteLine("Please enter the number you wish to factorize");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The number you entered was {0} and it's factorial is {1}", number, Factorial(number));
            }

            int Factorial(int n)
            {
               if (n >= 2) return n * Factorial(n - 1);
               return 1;
            } 
        }
    }
}
