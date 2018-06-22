using System;

namespace Classes
{
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
