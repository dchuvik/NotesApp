using System;
using System.Collections.Generic;

namespace FactoryPatternExercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myNewVehicle = VehicleFactory.GetVehicle();

            myNewVehicle.Drive();
        }
    }
}
