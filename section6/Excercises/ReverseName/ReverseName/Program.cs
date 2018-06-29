using System;

namespace ReverseName
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = " ";
           
            Console.WriteLine("Enter name: ");
             name = Console.ReadLine();
            var array = new char[name.Length];

            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("reversed: " + reversed);
        }
    }
}
