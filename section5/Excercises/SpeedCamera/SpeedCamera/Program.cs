using System;

namespace SpeedCamera
{
    class Program
    {
        static void Main(string[] args)
        {
            var demerits = 0;

            Console.WriteLine("Enter the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter current speed: ");
            var currentSpeed = Convert.ToInt32(Console.ReadLine());

            if(currentSpeed < speedLimit) 
            {
                Console.WriteLine("ok");
            }
            else if (currentSpeed > speedLimit)
            {
                demerits = (currentSpeed - speedLimit) / 5;
                Console.WriteLine("You have: " + demerits + " demerits!");
            }
            if (demerits > 12)
            {
                Console.WriteLine("License Suspended!");
            }
        }
    }
}
