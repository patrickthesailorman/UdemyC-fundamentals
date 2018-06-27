﻿using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            const int passwordLength = 10;

            var buffer = new char[passwordLength];


            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = ((char)('a' + random.Next(0, 26)));

                var password = new String(buffer);

                Console.WriteLine(password);
            }
           
        }
    }
}
