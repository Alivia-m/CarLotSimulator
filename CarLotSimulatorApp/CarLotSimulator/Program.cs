﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot carInventory = new CarLot();

            Car jeep = new Car() { Color = "black", Year = 2012, Make = "Jeep", Model = "Wrangler", EngineNoise = "rickety", HonkNoise = "beep beep"  , IsDrivable = false };
            carInventory.CarLotInventory.Add(jeep);

            Car cadillac = new Car() { Color = "red", Year = 2008, Make = "Cadillac", Model = "Escalade", EngineNoise = "vroom", HonkNoise = "honk honk", IsDrivable = true };
            carInventory.CarLotInventory.Add(cadillac);

            Car ford = new Car() { Color = "blue", Year = 2016, Make = "Ford", Model = "Fusion", EngineNoise = "silent", HonkNoise = "boop boop", IsDrivable = true};
            carInventory.CarLotInventory.Add(ford);


            Console.WriteLine($"Number of cars availible: {CarLot.numberOfCars}");
            foreach(var car in carInventory.CarLotInventory)
            {
                Console.WriteLine();
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }

            jeep.MakeEngineNoise();
            jeep.MakeHonkNoise();

            cadillac.MakeEngineNoise();
            cadillac.MakeHonkNoise();

            ford.MakeEngineNoise();
            ford.MakeHonkNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
