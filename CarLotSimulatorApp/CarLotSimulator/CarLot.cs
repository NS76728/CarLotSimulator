using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class CarLot
    {
        public static int numberOfCars=0;


        List<Car> lotList = new List<Car>();

        public void addTo(Car x)
        {
            lotList.Add(x);
            numberOfCars++;
        }

        public void printList()
        {
           
            foreach (var Car in lotList)
            {
                Console.WriteLine("Number of cars in the lot: " + numberOfCars);
                Console.WriteLine(Car.EngineNoise);
                Console.WriteLine(Car.HonkNoise);
                Console.WriteLine(Car.Year);
                Console.WriteLine(Car.Make);
                Console.WriteLine(Car.Model);
                Console.WriteLine(Car.IsDriveable);
                Console.WriteLine("---------------------------");
            }



        }
        


    }
}
