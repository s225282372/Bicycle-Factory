using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleFactory
{
    abstract class WorkShop
    {
        public abstract Bicycle MakeBicycle(string BicycleName);
        public Bicycle OrderBicycle(string BicycleName)
        {
            Bicycle ReturnMe = MakeBicycle(BicycleName);

            ReturnMe.CreateFrame();
            ReturnMe.AddWheels();
            ReturnMe.AddHandles();
            ReturnMe.AddBrakes();
            ReturnMe.AddPedals();
            ReturnMe.AddSeat();

            return ReturnMe;
        }
    }
}
