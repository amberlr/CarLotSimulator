using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            CarLot lot = new CarLot(); //bonus 2

            //Now that the Car class is created we can instanciate 3 new cars
            Car car1 = new Car();
            //adding car to list from bonus 2
            lot.CarList.Add(car1);

            //Set the properties for each of the cars

            //Standard member initializer syntax:
            car1.Make = "Toyota";
            car1.Model = "Camry";
            car1.Year = 2000;
            car1.EngineNoise = "";
            car1.HonkNoise = "";
            car1.IsDriveable = true;
            //Call each of the methods for each car
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);


            //Object initializer syntax
            var car2 = new Car() { Make = "Honda", Model = "Civic", Year = 2000, EngineNoise = "dead", HonkNoise = "rip", IsDriveable = false };
            //is var best practice or Car?
            //adding car to list from bonus 2
            lot.CarList.Add(car2);
            //Call each of the methods for each car
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);


            //Constructor initializer syntax
            Car car3 = new Car("Tesla", "Model S", 2018, "pretty", "wow", true);
            //adding car to list from bonus 2
            lot.CarList.Add(car3);
            //Call each of the methods for each car
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            //See above answers - car1 used standard member initializer, car 2 did object initializer, car3 did constructor initializer


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in lot.CarList) //you have to do lot.CarList because CarList exists in CarLot class
            {
                Console.WriteLine($"Make     Model    Year");
                Console.WriteLine($"---------------------");
                Console.WriteLine($"{car.Make}   {car.Model}    {car.Year}"); //can't just do car.. you need to access the properties as well
                Console.WriteLine();
            }
            
            //Exercise 2 of Static Keyword lecture material:

            var honda = new Car();
            Console.WriteLine($"{CarLot2.NumberOfCars++}");

            var toyota = new Car();
            Console.WriteLine($"{CarLot2.NumberOfCars++}");

            var lexus = new Car();
            Console.WriteLine($"{CarLot2.NumberOfCars++}");
        }
    }
}
