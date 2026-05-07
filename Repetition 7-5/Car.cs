using System;
using System.Collections.Generic;
using System.Text;

namespace Repetition_7_5
{
    public class Car : Vehicle
    {
        public int Doors { get; }

        public Car(string brand, int maxSpeed, int doors) : base(brand, maxSpeed)
        {
            Doors = doors;
        }

        public override string GetVehicleType()
        {
            return "Car";
        }

        public override string Describe()
        {
            return $"{base.Describe()}, Doors: {Doors}";
        }
    }
}
