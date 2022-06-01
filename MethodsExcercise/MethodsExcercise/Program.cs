using System;

namespace MethodsExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercise 1
            Console.WriteLine("What is your name?"); // output
            var name = Console.ReadLine(); // input
            Console.WriteLine("What is your favorite color?"); // output
            var favColor = Console.ReadLine(); // input
            Console.WriteLine("What is your favorite animal?"); // output
            var favAnimal = Console.ReadLine(); // input
            Console.WriteLine("Who is your favorite Celebrity?"); // output
            var favCelebrity = Console.ReadLine(); // input

            Console.WriteLine("Here is your MadLib...");
            Console.WriteLine();
            Console.WriteLine($"When a {favColor} limo pulled up, {name} noticed a {favAnimal} " +
                $"inside. The owner was of the limo was {favCelebrity}! {name} and {favCelebrity} became friends and got ice cream.");

        }
    }
}