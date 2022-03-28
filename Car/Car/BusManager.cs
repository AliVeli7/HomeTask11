using System;
using System.Collections.Generic;
using System.Text;

namespace CarTask
{
    class BusManager : CarManager
    {
        public override void info(Car bus)
        {
            Bus model = (Bus)bus;
            Console.WriteLine($"Brand:{bus.Brand} Model:{bus.Model} Color:{bus.Color} MaxSpeed:{bus.MaxSpeed} PassangerCount:{model.PassangerCount}");
        }

        public override void allinfo(Car[] models)
        {
            
            foreach (Car car in models)
            {
                Bus model = (Bus)car;
                Console.WriteLine($"Brand:{car.Brand} Model:{car.Model} Color:{car.Color} MaxSpeed:{car.MaxSpeed} PassangerCount:{model.PassangerCount}");
            }


        }

    }
}

