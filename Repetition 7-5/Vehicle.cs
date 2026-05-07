namespace Repetition_7_5
{
    public abstract class Vehicle : IDescribable
    {
        public string Brand { get; }
        public int MaxSpeed { get; }

        protected Vehicle(string brand, int maxSpeed)
        {
            Brand = brand;
            MaxSpeed = maxSpeed;
        }

        public abstract string GetVehicleType();

        public virtual string Describe()
        {
            return $"{GetVehicleType()} - Brand: {Brand}, Max Speed: {MaxSpeed} km/h";
        }
    }
}
