using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            var firstName = "Mosh";
            var lastName = "Hamedani";

            var FullName = firstName + " " + lastName;

            var MyFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
                
            Console.WriteLine(formattedNames);
        }
    }
}
