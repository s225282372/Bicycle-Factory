using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleFactory
{
    class Bicycle
    {
        public string Name { get; set; }

        public virtual void CreateFrame()
        {
            Console.WriteLine("Creating Frame");
        }

        public virtual void AddWheels()
        {
            Console.WriteLine("Adding Wheels");
        }

        public virtual void AddHandles()
        {
            Console.WriteLine("Adding Handles");
        }

        public virtual void AddBrakes()
        {
            Console.WriteLine("Adding Brakes");
        }

        public virtual void AddPedals()
        {
            Console.WriteLine("Adding Pedals");
        }

        public virtual void AddSeat()
        {
            Console.WriteLine("Adding a Seat");
        }
    }
}
