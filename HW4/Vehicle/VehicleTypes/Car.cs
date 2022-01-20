using System;

namespace Vehicle.VehicleTypes
{
    /// <summary>
    /// A car
    /// </summary>
    public class Car : AbstractVehicle
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
        /// Constructor
        /// </summary>
        /// <param name="carKey">Key to start the car</param>
        /// <param name="color">Primary color</param>
        public Car(Key carKey, Color color) : this(carKey, color, 100)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="carKey">Key to start the car</param>
        /// <param name="color">Primary color</param>
        /// <param name="topSpeed">Top speed in MPH</param>
        public Car(Key carKey, Color color, double topSpeed) : base(color, topSpeed)
        {
            this.CarKey = carKey;
        }

        /// <summary>
        /// Try to start the car
        /// </summary>
        /// <param name="carKey">Key to start the car with</param>
        /// <returns>True if the car could be started</returns>
        public bool TryToStart(Key carKey)
        {
            if (this.CarKey.KeyMatches(carKey))
            {
                this.Start();
                return true;
            }

            // This means the key doesn't match
            return false;
        }

        /// <summary>
        /// Shut off the car
        /// </summary>
        /// <returns>The key to the car</returns>
        public Key Shutoff()
        {
            if (this.IsStated())
            {
                this.Stop();
            }
            else
            {
                Console.WriteLine("Car is not started");
            }

            return this.CarKey;
        }

        /// <summary>
        /// Description of the car
        /// </summary>
        /// <returns>A description of the car</returns>
        public override string GetDescription()
        {
            return string.Format("{0} car, tops out at {1} mph", this.Color.ToString(), this.MaxSpeed);
        }
    }
}
