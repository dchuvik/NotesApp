using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Toyota", "Camry", 2009);
            Console.WriteLine(car1.Make);
            Console.WriteLine(car1.Model);
            Console.WriteLine(car1.Year); 
            Console.WriteLine();

            Car car2 = new Car("Honda", "Civic", 2020);
            Console.WriteLine(car2.Make);
            Console.WriteLine(car2.Model);
            Console.WriteLine(car2.Year);
            Console.WriteLine();

        }
    }
}
