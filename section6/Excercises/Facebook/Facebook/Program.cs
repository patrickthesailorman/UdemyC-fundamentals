using System;

namespace Facebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new String;

            while (name != " ")
            {
                var names[] = new[];
                Console.WriteLine("Enter name: ");
                var name = Console.ReadLine();

                names.push(name);
            }
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
