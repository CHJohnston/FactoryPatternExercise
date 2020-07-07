using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExerciseConsoleUI
{
    public class Car: IVehicle
    {
        public void Drive() 
        {
            Console.WriteLine("Building a Car!");
        }
    }
}
