using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleFactory
{
    class SteelFrame:WorkShop
    {
        public override Bicycle MakeBicycle(string BicycleName)
        {
            Bicycle theBicycle = null;

            if (BicycleName == "Mountain Bike")
                theBicycle = new MountainBike("Steel");
            if (BicycleName == "Racing Bike")
                theBicycle = new RacingBike("Steel");
            if (BicycleName == "Tricycle")
                theBicycle = new Tricycle("Steel");

            return theBicycle;
        }
    }
}
