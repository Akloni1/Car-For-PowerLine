using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            var passengerCar = new PassengerCar("Легковой", 8, 60, 90, 3);
            var truck = new Truck("Грузовой", 20, 100, 60, 600);
            var sportCar = new SportCar("Спортивный", 15, 50, 150);
            Car car = passengerCar;
            Console.WriteLine(car.TravelTime(180) + " ч.");
            Console.WriteLine(car.PowerReserve() + " км.");
            Console.WriteLine(car.PowerReserveLoadedCar() + " км.");
        }
    }
}