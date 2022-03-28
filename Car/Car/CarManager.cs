using System;
using System.Collections.Generic;
using System.Text;

namespace CarTask
{
    class CarManager
    {
        public virtual void info(Car car)
        {
            Console.WriteLine($"Brand:{car.Brand} Model:{car.Model} Color:{car.Color} MaxSpeed:{car.MaxSpeed}");
        }

        public virtual void allinfo(Car[] cars)
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"Brand:{car.Brand} Model:{car.Model} Color:{car.Color} MaxSpeed:{car.MaxSpeed}");
            }
        }
    }
}
