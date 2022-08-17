using System;

namespace Car
{
    public class PassengerCar : Car
    {
        public int passengersCount { get; set; }

        public PassengerCar(string type, double fuelConsumption, int tankCapacity, double speed, int passengersCount)
              : base(type, fuelConsumption, tankCapacity, speed)
        {
            this.passengersCount = passengersCount;
        }
        public override double PowerReserveLoadedCar()
        {
            if (passengersCount <= 5 && passengersCount > 0)
            {
                double remainingInterest = 1 - passengersCount * 6 * 0.01;
                return tankCapacity / fuelConsumption * 100 * remainingInterest;
            }
            else
            {
                Console.WriteLine("Введите корректное число пассажиров");
                return 0;
            }
        }
    }
}