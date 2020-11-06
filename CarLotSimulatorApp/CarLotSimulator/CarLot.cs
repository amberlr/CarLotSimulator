using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection.Metadata;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {
        //Create a CarLot class
        //It should have at least one property: a List of cars
        //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
        //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        public List<Car> CarList { get; set; } = new List<Car>();
        //Type is held in <>, I did string, but changed it to Car since I want to hold Cars here. I might need help with this
        
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }



    //exercise 2 in static keyword lecture material:
    //Building on our car lot simulator project, create a CarLot class with a static field called numberOfCars. 
    //Have this number only increment when in our program we create a new Car. 
    //From there create 3 cars in the Main() and then each time you create a car, do a Console.WriteLine() 
    //printing the current number of cars in the car lot.
    public static class CarLot2
    {
        public static int NumberOfCars { get; set; }
        
        static CarLot2() 
        {
            NumberOfCars++;
        }
    }
}
