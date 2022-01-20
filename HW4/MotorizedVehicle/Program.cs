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
            // Electric Car
            Key electricKey = KeyFactory.MakeNewKey();
            ElectricCar electricCar = new ElectricCar(electricKey, Color.Blue, 75);
            electricCar.GetDescription();
            electricCar.Drive(20);
            electricCar.Drive(65);
            electricCar.Drive(30);
            electricCar.Drive(25);
            electricCar.GetDescription();

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
