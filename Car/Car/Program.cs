using System;

namespace CarTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Bus bus1 = new Bus("GMC", "B-series", "red", 190, 50);
            Bus bus2 = new Bus("Mercedes", "A-series", "white", 190, 50);
            Car car1 = new Car("BMW", "M5", "gold", 190);
            Car car2 = new Car("Mercedes", "GLS", "black", 190);
            Car car3 = new Car("BMW", "X7", "black", 190);
            Car car4 = new Car("Cadillac", "ESCALADE", "black", 190);
            Car car5 = new Car("Ford", "Mustang", "black", 190);
            
            CarManager car = new CarManager();
            CarManager carManager = new BusManager();
            BusManager bus = new BusManager();
            car.info(bus1);
            car.info(car1);
            Console.WriteLine("---------------");


            carManager.info(bus1);
            Console.WriteLine("---------------");


            bus.info(bus1);
            Console.WriteLine("---------------");


            Car[] cars = new Car[] { bus1, bus2, car1, car2, car3, car4, car5 };
            car.allinfo(cars);
            Console.WriteLine("---------------");
            
            
            Bus[] models = new Bus[] { bus1, bus2};
            carManager.allinfo(models);



        }
    }
}
