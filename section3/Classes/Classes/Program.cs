using System;

namespace Classes
{
    public class Person 
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.firstName = "John";
            john.lastName = "Smith";

            john.Introduce();
        }
    }
}
