using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car  *
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable  *
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()  *
            //The methods should take one string parameter: the respective noise property  *


            //Now that the Car class is created we can instanciate 3 new cars  *
            //Set the properties for each of the cars  *
            //Call each of the methods for each car   *

            CarLot newLot = new CarLot();            
            
            //Custom Constructor\\
            Car car1 = new Car(2019,"Dodge", "Ram", "Vrooooooom!", "Honk Honk", true);
                                   
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();
            newLot.CarList.Add(car1);

            //Dot Notation\\
            Car car2 = new Car();
                                    
            car2.Year = 2017;
            car2.Make = "Chrysler";
            car2.Model = "Pacifica";
            car2.EngineNoise = "Weeeeeeee!";
            car2.HonkNoise = "Meep Meep!";
            car2.IsDriveable= true;

            car2.MakeEngineNoise();
            car2.MakeHonkNoise();
            newLot.CarList.Add(car2);

            //Object Initializer Syntax\\
            Car car3= new Car() { Year = 1998, Make = "Chevrolet", Model = "S-10", EngineNoise = "Wop Wop", HonkNoise = "Aooooooga!", IsDriveable = true};
                                  
            car3.MakeEngineNoise();
            car3.MakeHonkNoise();
            newLot.CarList.Add(car3);
            Console.WriteLine();

            Console.WriteLine("__________________________________");

            foreach (var car in newLot.CarList) 
            {
                Console.WriteLine();
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} and Model: {car.Model}");
            }
            Console.WriteLine($"There are {CarLot.numberOfCars} cars on the lot currently.");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car  *

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
