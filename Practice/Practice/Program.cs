using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Kata.High("Hello"));

        }

    }

    public class Kata
    {
        public static string High(string s)
        {
          s.Split(" ")
          s.Select(word => word.Select(c => c));
        }
    }

}

//foreach (char c in sentence)
//{
//   var changedChar = char.ToUpper(c);
//}