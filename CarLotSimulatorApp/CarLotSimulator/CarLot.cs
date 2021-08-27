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
            for (int x=0; x<lotList.Count; x++)
            {
                Console.WriteLine(lotList[x]);
            }
        }
        


    }
}
