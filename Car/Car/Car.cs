using System;
using System.Collections.Generic;
using System.Text;

namespace CarTask
{
    class Car
    {
        public string Brand;
        public string Model;
        public string Color;
        public int MaxSpeed;

        public Car()
        {
            Console.WriteLine("Car created.");
        }

        public Car(string brand, string model):this()
        {
            Brand = brand;
            Model = model;
        }

        public Car(string brand , string model, string color, int maxSpeed):this(brand,model)
        {
            Color = color;
            MaxSpeed = maxSpeed;
        }
    }
}
