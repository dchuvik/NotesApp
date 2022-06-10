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

        }
    }
}
