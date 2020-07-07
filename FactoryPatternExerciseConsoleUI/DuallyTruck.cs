using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExerciseConsoleUI
{
    public class DuallyTruck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a Dually Truck!");
        }
    }
}
