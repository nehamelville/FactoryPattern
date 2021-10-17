using System;
namespace FactoryPattern
{
    public static class VehicleFactory
    {
        static VehicleFactory()
        {
        }
        public static IVehicle GetVehicle(string tires)
        {
            switch (tires)
            {
                case "4":
                        return new Car();
      
                case "2":
                        return new MotorCycle();
                case "8":
                    return new BigRig();
                     
                default: return new MotorCycle();
                   
                    
            }


        }
    }
}

