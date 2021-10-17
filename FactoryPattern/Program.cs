using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n2 for Motocycle\n4 for Car\n8 for BigRig\nChoose number of tires to build a vehicle:");    
            string numberOfTires = Console.ReadLine();
            IVehicle vehicle = VehicleFactory.GetVehicle(numberOfTires);
            vehicle.Drive();
           
        }
    }
}
