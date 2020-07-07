using System;

namespace FactoryPatternExerciseConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {//Factory Pattern Exercise
         //Build a Vechile based on the number of tires entered by the user
                    
        Console.WriteLine("Let's Build a New Vechicle!");
        Console.Write("Enter the number of Tires for your Vechicle (2, 4, or 6): ");       
          
        string numberofTires = Console.ReadLine();
        
        if (numberofTires == "2" || numberofTires == "4" || numberofTires == "6")                    
        {
            IVehicle vehicle = VechicleFactory.GetVehicle(numberofTires);
            vehicle.Drive();           
        } 
        else
        {
            Console.WriteLine($"{numberofTires} is not a valid input!!");
        }           
        }
    }
}
