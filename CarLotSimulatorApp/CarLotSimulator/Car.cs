using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
        public string Color { set; get; }
        public int Year { set; get; }
        public string Make { set; get; }
        public string Model { set; get; }
        public string EngineNoise { set; get; }
        public string HonkNoise { set; get; }
        public bool IsDrivable { set; get; }


        public Car(string color, int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable = false)
        {
            Color = color;
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
        }

        public Car()
        {
        }

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }
    }
}
