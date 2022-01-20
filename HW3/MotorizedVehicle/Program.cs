using System;
using Vehicle;
using Vehicle.VehicleTypes;

namespace MotorizedVehicle
{
    class Program
    {
        /// <summary>
        /// Demo using our vehicle objects
        /// </summary>
        /// <param name="args">Commandline arguments</param>
        static void Main(string[] args)
        {
            // Create and tryout a car
            Key carOneKey = KeyFactory.MakeNewKey();
            Car carOne = new Car(carOneKey, Color.Red);
            Console.WriteLine("Car 1 is a " + carOne.GetDescription());

            TryToStartCar("CarOne", carOne, "KeyOne", carOneKey);
            WriteMaxMph(carOne);

            Console.WriteLine("");
            Console.WriteLine("");

            // Create and tryout a second car
            Key carTwoKey = KeyFactory.MakeNewKey();
            Car carTwo = new Car(carTwoKey, Color.Gray, 95.3);

            Console.WriteLine("Car 2 is a " + carTwo.GetDescription());
            WriteMaxMph(carTwo);

            // Try different keys
            TryToStartCar("CarTwo", carTwo, "KeyOne", carOneKey);
            TryToStartCar("CarTwo", carTwo, "KeyTwo", carTwoKey);

            Console.WriteLine("");
            Console.WriteLine("");

            // Create and tryout a basic motorcycle
            Motorcycle motorcycleOne = new Motorcycle(Color.Black);
            Console.WriteLine("Motorcycle is a " + motorcycleOne.GetDescription());
            WriteMaxMph(motorcycleOne);

            motorcycleOne.Kickstart();
            motorcycleOne.SwitchOff();

            Console.WriteLine("");
            Console.WriteLine("");

            // Create and tryout a fancy motorcycle
            Key bikeKey = KeyFactory.MakeNewKey();
            FancyMotorcycle motorcycleTwo = new FancyMotorcycle(Color.Black, Color.Orange, bikeKey);
            Console.WriteLine("Facy motorcycle is a " + motorcycleTwo.GetDescription());
            WriteMaxMph(motorcycleTwo);
            motorcycleTwo.Kickstart();

            // Try different keys
            TryToStartBike("Fany motorcycle", motorcycleTwo, "CarKeyOne", carOneKey);
            TryToStartBike("Fany motorcycle", motorcycleTwo, "BikeKey", bikeKey);

            bikeKey = motorcycleTwo.Shutoff();

            // Wait for user to end console session
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// Try to start a car
        /// </summary>
        /// <param name="carName"></param>
        /// <param name="car"></param>
        /// <param name="keyName"></param>
        /// <param name="key"></param>
        private static void TryToStartCar(string carName, Car car, string keyName, Key key)
        {
            if (car.TryToStart(key))
            {
                Console.WriteLine("Started " + carName + " with " + keyName);
            }
            else
            {
                Console.WriteLine("Failed to start " + carName + " with " + keyName);
            }
        }

        /// <summary>
        /// Try to start a fancy motorcycle
        /// </summary>
        /// <param name="bikeName"></param>
        /// <param name="bike"></param>
        /// <param name="keyName"></param>
        /// <param name="key"></param>
        private static void TryToStartBike(string bikeName, FancyMotorcycle bike, string keyName, Key key)
        {
            if (bike.TryToStart(key))
            {
                Console.WriteLine("Started " + bikeName + " with " + keyName);
            }
            else
            {
                Console.WriteLine("Failed to start " + bikeName + " with " + keyName);
            }
        }

        /// <summary>
        /// Write the max MPH
        /// </summary>
        /// <param name="vehicle">A vehicle - works for any type</param>
        private static void WriteMaxMph(AbstractVehicle vehicle)
        {
            Console.WriteLine("The max MPH is " + vehicle.MaxSpeed);
        }
    }
}
