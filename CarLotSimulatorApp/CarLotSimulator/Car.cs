﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
        public  int Year { get; set; }
        public string Make { get; set; }
        public  string Model { get; set; }
        public  string EngineNoise { get; set; }
        public  string HonkNoise { get; set; }
        public  bool IsDriveable { get; set; }

        public Car(int year, string make,string model, string enginenoise, string honknoise, bool isdrivable )
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;
            IsDriveable = isdrivable;
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
            Console.WriteLine(HonkNoise );
            
        }



       





    }

}
