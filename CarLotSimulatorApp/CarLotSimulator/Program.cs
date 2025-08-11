using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var carLotOne = new CarLot();
            
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            
            
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            var carOne = new Car();
            carOne.Make = "Buick";
            carOne.Model = "LeSabre";
            carOne.Year = 2000;
            carOne.IsDrivable = false;
            carOne.MakeEngineNoise("st st st stutter...");
            carOne.MakeHonkNoise("HONK!");
            
            carLotOne.ParkingLot.Add(carOne);
            
            var carTwo = new Car()
            {
                Make = "Volkswagen", Model = "Jetta", Year = 2005, IsDrivable = false
            };
            carTwo.MakeEngineNoise("Nothing...");
            carTwo.MakeHonkNoise("Beep Beep!");
            
            carLotOne.ParkingLot.Add(carTwo);


            var carThree = new Car("Kia", "Soul", 2018, true);
                carThree.MakeEngineNoise("Vroom!");
                carThree.MakeHonkNoise("Beeeeep!");
                
                carLotOne.ParkingLot.Add(carThree);


            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");
            
            carLotOne.CheckCars();
        }
    }
}
