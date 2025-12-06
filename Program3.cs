

//GETTING INPUT FROM THE USER
using System;
namespace program
{
    class sample
    {
        static void Main()
        {
            Console.WriteLine("Enter the value 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value 2: ");
            int b = int.Parse(Console.ReadLine());
            int addition = (a + b);
            Console.WriteLine($"The output is: {addition}");

        }
    }
}

