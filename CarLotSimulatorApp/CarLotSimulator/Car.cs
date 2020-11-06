using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; } //you can initialize them here if you want
        
        public Car() 
        {
            //this is here so you don't need to use the properties in the program.cs
        }
        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDriveable)//this is so you can list just the values for the cars
        {
            //you have to give each property a value though and they have to be in this order when put in the parameters - look at car3 example for use
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        public void MakeEngineNoise(string engineNoise) 
        {
        
        }

        public void MakeHonkNoise(string honkNoise) 
        {
        
        }

    }
}
