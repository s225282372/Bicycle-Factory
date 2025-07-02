using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleFactory
{
    class MountainBike:Bicycle
    {
        private readonly string material;

        public MountainBike(string material)
        {
            this.Name = "Mountain Bike";
            this.material = material;
        }

        public override void CreateFrame()
        {
            Console.WriteLine("Creating {0} Frame",material);
        }
    }
}
