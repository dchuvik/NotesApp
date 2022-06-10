using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public Car() 
        { 
        }
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;  
            Year = year;
        }
    }
}
