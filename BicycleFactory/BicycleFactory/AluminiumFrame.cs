using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleFactory
{
    class AluminiumFrame:WorkShop
    {
        public override Bicycle MakeBicycle(string BicycleName)
        {
            Bicycle theBicycle = null;

            if (BicycleName == "Mountain Bike")
                theBicycle = new MountainBike("Aluminium");
            if (BicycleName == "Racing Bike")
                theBicycle = new RacingBike("Aluminium");
            if (BicycleName == "Tricycle")
                theBicycle = new Tricycle("Aluminium");

            return theBicycle;
        }
    }
}
