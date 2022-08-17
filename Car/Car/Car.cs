
namespace Car
{
    public abstract class Car
    {
        public string type { get; set; }
        public double fuelConsumption { get; set; }
        public int tankCapacity { get; set; }
        public double speed { get; set; }
      

        public Car(string type, double fuelConsumption, int tankCapacity, double speed)
        {
            this.type = type;
            this.fuelConsumption = fuelConsumption;
            this.tankCapacity = tankCapacity;
            this.speed = speed;
        }

        public double PowerReserve()
        {
            return tankCapacity / fuelConsumption * 100;
        }
        public double TravelTime(double distance)
        {
            return distance / speed;
        }
        public abstract double PowerReserveLoadedCar();
    }
}
