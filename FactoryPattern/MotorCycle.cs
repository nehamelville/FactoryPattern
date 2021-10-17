using System;
namespace FactoryPattern
{
    public class MotorCycle:IVehicle
    {
        public MotorCycle()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Builiding a Motorcycle");
        }
    }
}
