//THE SIMPLE PROGRAM
//using System;
//namespace program
//{
//    class sample
//    {
//        static void Main()
//        {
//            Console.WriteLine("The Simple Program");
//        }
//    }
//}

//THE PROGRAM BY PASSING ARGUMENTS
//using System;
//namespace program
//{
//class sample
//    {
//        static void Main(string[] args)
//        {
//          if(args.Length==0)
//            {
//                Console.WriteLine("No arguments are passed");
//            }
//            else
//            {
//                Console.WriteLine("The Length of the argument is: " + args.Length);
//                Console.WriteLine("Hello " + args[1] + ", " + "Welcome to C# programming");
//            }
//        }
//    }
//}

//GETTING INPUT FROM THE USER
//using System;
//namespace program
//{
//    class sample
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter the value 1: ");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter the value 2: ");
//            int b = int.Parse(Console.ReadLine());
//            int addition = (a + b);
//            Console.WriteLine($"The output is: {addition}");

//        }
//    }
//}

//PRINTING THE OUTPUT USING PLACEHOLDER
//using System;
//namespace program
//{
//    class sample
//    {
//        static void Main()
//        {
//            string name = "XXX";
//            Console.WriteLine("My name is: {0}",name);
//            int age = 18;
//            Console.WriteLine("My age is: {0}",age);
//            string favouritesubject = "Science";
//            Console.WriteLine("My favourite subject is: {0}",favouritesubject);
//        }
//    }
//}



//INITIALIZING AN ARRAY
//using System;
//namespace program
//{
//    class sample
//    {
//        static void Main()
//        {
//            int[] a = new int[5];
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("Enter the Value: ");
//                int b = int.Parse(Console.ReadLine());
//                a[i] = b;
//            }
//                Console.WriteLine("The values in the array are: ");
//                for (int i = 0; i<5;i++)
//                {
//                Console.WriteLine(a[i]);
//            }
//            }
//        }
//    }

//SORTING THE ARRAYS
//using System;
//namespace program
//{
//    class sample
//    {
//        static void Main()
//        {
//            int[] b = new int[5];
//            Console.WriteLine("Enter the values: ");
//            for (int i = 0; i < 5; i++)
//            {
//                b[i] = int.Parse(Console.ReadLine());

//            }
//            Console.WriteLine("The values of the array are: ");
//            for(int i=0;i<5;i++)
//            {
//                Console.WriteLine(b[i]);
//            }

//            Array.Sort(b);
//                Console.WriteLine("The Sorted array is: ");
//                for(int i=0;i<5;i++)
//            {
//                Console.WriteLine(b[i]);
//            }
//        }
//    }
//}

//REVERSING THE ARRAY
//using System;
//namespace program
//{
//    class sample
//    {
//        static void Main()
//        {
//            int[] a = new int[5];
//                Console.WriteLine("Enter the values: ");
//            for (int i = 0; i<5; i++)
//            {
//                a[i] = int.Parse(Console.ReadLine());
//            }
//            Console.WriteLine("The values of the array are: ");
//                for (int i = 0; i<5; i++)
//            {
//                Console.WriteLine(a[i]);
//            }
//            Array.Reverse(a);
//            Console.WriteLine("The reversed array is:");
//            for (int i = 0; i < 5; i++)
//            { 
//            Console.WriteLine(a[i]);
//            }
//        }
//    }
//}

//COPYING ONE ARRAY INTO ANOTHER
using System;
namespace program
{
    class sample
    {
        static void Main()
        {
            int[] a = new int[5];
            Console.WriteLine("Enter the Values: ");
            for(int i=0;i<5;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The Values of the array are: ");
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(a[i]);
            }
            int[] b = new int[5];
            Array.Copy(a, b, a.Length);
            Console.WriteLine("The Copied array is:");
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
    
}



