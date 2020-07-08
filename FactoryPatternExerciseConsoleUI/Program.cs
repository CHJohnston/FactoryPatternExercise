using System;

namespace FactoryPatternExerciseConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {//Factory Pattern Exercise
         //Build a Vechile based on the number of tires entered by the user
                    
        Console.WriteLine("Let's Build a New Vechicle!");

        //Check for valid values, if not keep asking user until the valid number is entered
        //If the input value is valid, then create the vehicle using the Factory Pattern Vechicle Factory
        Console.Write("Enter the number of Tires for your Vechicle (2, 4, or 6): ");
        string numberofTires = Console.ReadLine();       
        bool validInput = false;
        while (validInput == false)
            {
                if (numberofTires == "2" || numberofTires == "4" || numberofTires == "6")
                {
                    //This is a valid input -- create the vehicle using the Factory Pattern IVechicle Factory
                    validInput = true;                    
                    IVehicle vehicle = VechicleFactory.GetVehicle(numberofTires);
                    vehicle.Drive();                
                }
                else
                {
                    Console.Write($"{numberofTires} is not a valid input!! -- Enter another value : ");
                    numberofTires = Console.ReadLine();
                }
            }  
        }
    }
}
