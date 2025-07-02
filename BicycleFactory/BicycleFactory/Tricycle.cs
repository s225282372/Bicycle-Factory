using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BicycleFactory
{

    class Tricycle:Bicycle
    {
        private readonly string material;
     
        public Tricycle(string material)
        {
            this.Name = "Tricycle";
            this.material = material;
        }

        public override void CreateFrame()
        {
            Console.WriteLine("Creating {0} Frame", material);
        }
    }
}
