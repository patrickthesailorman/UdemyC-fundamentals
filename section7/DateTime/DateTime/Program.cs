﻿using System;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2018, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: "+ now.Hour);
            Console.WriteLine("Minute: " + now.Minute);
        }
    }
}
