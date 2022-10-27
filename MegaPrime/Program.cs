using System;

namespace MegaPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;

            Console.WriteLine("Please enter a number you would like to find the MEGAPRIME of...");

            //Checks whether the number entered is valid and re prompts you if not.
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out input))
                    break;
                else
                    Console.WriteLine("Number invalid, try again");

            }

            //Displays the output on the console
            Console.WriteLine($"The mega prime numbers are {string.Join(", ", PrimeFinder.GetMegaPrime(input))}");
            Console.ReadLine();
        }
    }
}
