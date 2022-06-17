using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    public class VehicleFactory
    {
        //write a method that will produce vehicle based on number of wheels
        public static IVehicle GetVehicle()
        {
            Console.WriteLine("How many wheels does the vehicle you want have?");

            var answer = Console.ReadLine();

            switch (Convert.ToInt32(answer.ToLower()))
            {
                case 2 : return new Motorcycle();
                case 4: return new Car();
                default : return new Car();

            }



            //if (answer == "2")
            //{
            //    return new Motorcycle();
            //}
            //else if (answer == "4")
            //{
            //    return new Car();
            //}
            //else
            //{
            //    return new Car();
            //}
        }


    }
}
