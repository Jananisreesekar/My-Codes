//THE PROGRAM BY PASSING ARGUMENTS
using System;
namespace program
{
class sample
    {
        static void Main(string[] args)
        {
          if(args.Length==0)
            {
                Console.WriteLine("No arguments are passed");
            }
            else
            {
                Console.WriteLine("The Length of the argument is: " + args.Length);
                Console.WriteLine("Hello " + args[1] + ", " + "Welcome to C# programming");
            }
        }
    }
}


