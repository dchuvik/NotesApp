using System;

namespace Declare_and_initialize_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "David";
            int age = 22;
            char grade = 'A';
            bool isMarried = true;
            double gpa = 3.94;
            decimal pi = 3.1415926535m;

            Console.WriteLine($"My name is {name} and I am {age} years old. It is {isMarried} that I am married. My college GPA was {gpa} because most of my grades were {grade}'s. The first numbers of pi are {pi}.");
        }
    }
}
