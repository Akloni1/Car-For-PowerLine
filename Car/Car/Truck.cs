using System;

namespace Car
{
    public class Truck: Car
    {
   
        public int  loadCapacity  { get; set; }

        public Truck(string type, double  fuelConsumption, int  tankCapacity, double  speed, int  loadCapacity)
            : base(type, fuelConsumption, tankCapacity, speed)
        { 
            this.loadCapacity = loadCapacity;
        }   
        public override double PowerReserveLoadedCar()
        {
            if (loadCapacity <= 2000&& loadCapacity > 0)
            {
                double remainingInterest = 1 - loadCapacity / 200 * 4 * 0.01;
                return tankCapacity / fuelConsumption * 100 * remainingInterest;
            }
            else
            {
                Console.WriteLine("Введите корректный вес");
                return 0;
            }
        }   
    }
}