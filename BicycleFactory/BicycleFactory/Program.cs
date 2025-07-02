using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a Mountain Bike in the Steel Workshop... ");
            WorkShop workShop = new SteelFrame();
            Bicycle bicycle = workShop.OrderBicycle("Mountain Bike");
            Console.WriteLine("Bicycle Created: " + bicycle.GetType().Name);
            Console.WriteLine();

            Console.WriteLine("Creating a Racing Bike in the Almunium Workshop... ");
            workShop = new AluminiumFrame();
            bicycle = workShop.OrderBicycle("Racing Bike");
            Console.WriteLine("Bicycle Created: " + bicycle.GetType().Name);
            Console.WriteLine();

            Console.WriteLine("Creating a Tricycle in the Almunium Workshop... ");
            workShop = new AluminiumFrame();
            bicycle = workShop.OrderBicycle("Tricycle");
            Console.WriteLine("Bicycle Created: " + bicycle.GetType().Name);
            Console.WriteLine();

            Console.ReadLine();
            
            
        }
    }
}
