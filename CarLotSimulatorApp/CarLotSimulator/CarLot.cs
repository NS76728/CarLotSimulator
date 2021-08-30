using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class CarLot
    {
        List<Car> lotList = new List<Car>();

        public void addTo(Car x)
        {
            lotList.Add(x);
        }

        public void printList()
        {
           
            foreach (var Car in lotList)
            {
                Console.WriteLine(Car.EngineNoise);
                Console.WriteLine(Car.HonkNoise);
            }



        }
        


    }
}
