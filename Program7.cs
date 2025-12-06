//SORTING THE ARRAYS
using System;
namespace program
{
    class sample
    {
        static void Main()
        {
            int[] b = new int[5];
            Console.WriteLine("Enter the values: ");
            for (int i = 0; i < 5; i++)
            {
                b[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The values of the array are: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(b[i]);
            }

            Array.Sort(b);
            Console.WriteLine("The Sorted array is: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}

