//INITIALIZING AN ARRAY
using System;
namespace program
{
    class sample
    {
        static void Main()
        {
            int[] a = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the Value: ");
                int b = int.Parse(Console.ReadLine());
                a[i] = b;
            }
            Console.WriteLine("The values in the array are: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}

