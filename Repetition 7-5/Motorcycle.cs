using System;
using System.Collections.Generic;
using System.Text;

namespace Repetition_7_5
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string brand, int maxSpeed) : base(brand, maxSpeed)
        {
        }

        public override string GetVehicleType()
        {
            return "Motorcycle";
        }

        public void Wheelie()
        {
            Console.WriteLine($"{Brand} is balancing on its rear wheel!");
        }
    }
}
