using System;

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

            Car car1 = new Car(1969, "Shelby", "Cobra", "Vroom Vroom", "Beep Beep", true);
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();
            Console.WriteLine("-----------------");
            Car car2 = new Car()
            {
                Year = 2000,
                Make= "Ford",
                Model = "Mustange",
                EngineNoise= "Vroom",
                HonkNoise= "Beep",
                IsDriveable = true
            };
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();
            Console.WriteLine("-----------------");
            var car3 = new Car();
            car3.Year = 1995;
            car3.Make = "Honda";
            car3.Model = "Civic";
            car3.EngineNoise = "put put";
            car3.HonkNoise = "bep";
            car3.IsDriveable = false;
            car3.MakeEngineNoise();
            car3.MakeHonkNoise();
            Console.WriteLine("-----------------");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            CarLot lot1 = new CarLot();

            lot1.addTo(car1);
            lot1.addTo(car2);
            lot1.addTo(car3);

            lot1.printList();




            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
