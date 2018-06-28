using System;

namespace okToExit
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            while (true)
            {
                Console.WriteLine("enter a number or type \"ok\" to exit: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;
                else
                {
                    sum += Convert.ToInt32(input);

                }
                Console.WriteLine(sum);
            }
        }
    }
}
