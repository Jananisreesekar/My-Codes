//REVERSING THE ARRAY
using System;
namespace program
{
    class sample
    {
        static void Main()
        {
            int[] a = new int[5];
            Console.WriteLine("Enter the values: ");
            for (int i = 0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The values of the array are: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
            Array.Reverse(a);
            Console.WriteLine("The reversed array is:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}