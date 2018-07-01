using System;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Patrick McCarty ";
            
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
        }
    }
}
