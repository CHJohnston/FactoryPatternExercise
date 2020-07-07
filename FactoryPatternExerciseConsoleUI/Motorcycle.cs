using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExerciseConsoleUI
{
    class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a Motorcycle!");
        }
    }
}
