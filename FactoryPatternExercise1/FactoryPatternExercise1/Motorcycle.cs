using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Building a new Motorcycle!\n");
        }
    }
}
