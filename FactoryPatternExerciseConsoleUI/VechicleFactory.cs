using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExerciseConsoleUI
{
    public static class VechicleFactory
    {
        //The GetVechicle Method returns a class based on the number of tires entered

        public static IVehicle GetVehicle(string numberoftires) 
        {
            switch (numberoftires) 
            {
                case "2":
                    return new Motorcycle();
                case "4":
                    return new Car();
                case "6":
                    return new DuallyTruck();
                default:
                    return new Car();
            }
        }
    }
}
