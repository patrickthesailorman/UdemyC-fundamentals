using System;

namespace Facebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            var name = "";

            do
            {
                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();

                names.Add(name);
            }

            while (name != " ");
            {


                if (names.Count() == 1)
                {
                    Console.WriteLine(names[0] + " likes this");
                }
                else if (names.Count() == 2)
                {
                    Console.WriteLine(names[0] + " & " + names[1] + " like this");
                }
                else if (names.Count() > 2)
                {
                    Console.WriteLine(names[0] + " , " + names[1] + " & {0} others like this", names.Count() - 2);
                }
            }
        }
    }
}
