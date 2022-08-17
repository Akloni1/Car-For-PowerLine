using System;

namespace Car
{
    public class SportCar : Car
    {
        public SportCar(string type, double  fuelConsumption, int  tankCapacity, double  speed)
            :base(type, fuelConsumption, tankCapacity, speed) { }   
        public override double PowerReserveLoadedCar()
        {
            return tankCapacity / fuelConsumption * 100;// в задании не было указано чем нагружен спортивный автомобиль
        }       
    }
}