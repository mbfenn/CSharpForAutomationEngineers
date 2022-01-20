using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.VehicleTypes
{
    public class ElectricCar : Car
    {
        /// <summary>
        /// The number of tires
        /// </summary>
        public override int NumberOfTires
        {
            get { return 4; }
        }

        /// <summary>
        /// What key is reqired to start the car
        /// </summary>
        private Key CarKey;

        /// <summary>
        /// Percentage of battery the Electric car has left (0-100). 
        /// </summary>
        private int CarBatteryPercentage;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="carKey">Key to start the car</param>
        /// <param name="color">Primary color</param>
        public ElectricCar(Key carKey, Color color) : this(carKey, color, 100)
        {
        }

        public ElectricCar(Key carKey, Color color, double topSpeed) : base(carKey, color, topSpeed)
        {
            this.CarBatteryPercentage = 100;
        }

        /// <summary>
        /// Try to start the car
        /// </summary>
        /// <param name="carKey">Key to start the car with</param>
        /// <returns>True if the car could be started</returns>
        public bool TryToStart(Key carKey)
        {
            if (this.CarKey.KeyMatches(carKey) && this.CarBatteryPercentage > 0)
            {
                this.Start();
                return true;
            }

            // This means the key doesn't match or it had no battery left
            return false;
        }

        /// <summary>
        /// Drives for a particular amount of time, lowering the battery level
        /// </summary>
        /// <param name="miles">Amount of miles driven</param>
        public void Drive(int miles)
        {
            if (TryToStart(this.CarKey) && miles <= CarBatteryPercentage)
            {
                Console.WriteLine("Car started. Driving for {0} miles", miles);
                Console.WriteLine("Accelerating up to {0} mph", MaxSpeed);
                this.CarBatteryPercentage = this.CarBatteryPercentage - miles;
                Console.WriteLine("Slowing down to 0 mph.");
                Console.WriteLine("Car Battery Percentage remaining: {0}", CarBatteryPercentage);
            }
            else if (TryToStart(this.CarKey) && miles > CarBatteryPercentage)
            {
                int milesLeft = miles - CarBatteryPercentage;
                Console.WriteLine("Car started. Driving for {0} miles", miles);
                Console.WriteLine("Accelerating up to {0} mph", MaxSpeed);
                Console.WriteLine("Car ran out of battery after driving {0} miles", milesLeft);
                Console.WriteLine("Slowing down to 0 mph.");
                Recharge();
                Console.WriteLine("Car Recharged");
            }
            else
            {
                Console.WriteLine("Car is out of battery. Recharging.");
                Recharge();
                Console.WriteLine("Car Recharged");
            }
        }

        /// <summary>
        /// Resets Car Battery Percentage to 100%
        /// </summary>
        public void Recharge()
        {
            this.CarBatteryPercentage = 100;
        }

        /// <summary>
        /// Description of the car
        /// </summary>
        /// <returns>A description of the car</returns>
        public override string GetDescription()
        {
            return string.Format("{0} car, tops out at {1} mph. Percent battery left: {2}%", this.Color.ToString(), this.MaxSpeed, this.CarBatteryPercentage);
        }
    }
}
