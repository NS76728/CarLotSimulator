using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
        public  int year { get; set; }
        public string make { get; set; }
        public  string model { get; set; }
        public  string engineNoise { get; set; }
        public  string honkNoise { get; set; }
        public  bool IsDriveable { get; set; }

        public Car()
        {

        }


        public void MakeEngineNoise(string engineNoise)
        {
           Console.WriteLine( engineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(honkNoise );
            
        }



       





    }

}
