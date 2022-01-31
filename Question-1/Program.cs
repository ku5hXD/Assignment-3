// See https=//aka.ms/new-console-template for more information

using System;

namespace Program
{
    class DoTheMath
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please enter the numerator?");
            int numerator = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the denominator?");
            int denominator = Int32.Parse(Console.ReadLine());

            int quotient = numerator / denominator;
            int remainder = numerator % denominator;

            Console.WriteLine($"\nInteger division result = {quotient} with a remainder = {remainder}\n");

            float ans = (float)numerator / denominator;
            Console.WriteLine($"Floating point division result = {ans}\n");

            Console.WriteLine($"The result as a mixed fraction is {quotient} {remainder}/{denominator}\n");

        }
    }


}

