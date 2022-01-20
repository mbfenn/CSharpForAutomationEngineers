using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.VehicleTypes
{
    /// <summary>
    /// A fancy motorcycle
    /// </summary>
    public class FancyMotorcycle : Motorcycle
    {
        /// <summary>
        /// Motorcycle key
        /// </summary>
        private Key BikeKey;

        /// <summary>
        /// Secondary color
        /// </summary>
        private Color SecondaryColor;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="primaryColor">Primary color</param>
        /// <param name="secondaryColor">Secondary color</param>
        /// <param name="key">Key to start the motorcycle</param>
        public FancyMotorcycle(Color primaryColor, Color secondaryColor, Key key) : this(primaryColor, secondaryColor, key, 120)
        {
            
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="primaryColor">Primary color</param>
        /// <param name="secondaryColor">Secondary color</param>
        /// <param name="key">Key to start the motorcycle</param>
        /// <param name="topSpeed">Top speed in MPH</param>
        public FancyMotorcycle(Color primaryColor, Color secondaryColor, Key key, double topSpeed)
            : base(primaryColor, topSpeed)
        {
            this.BikeKey = key;
            this.SecondaryColor = secondaryColor;
        }

        /// <summary>
        /// Try to start the motorcycle
        /// </summary>
        /// <param name="bikeKey">Key to start the motorcycle with</param>
        /// <returns>True if the motorcycle could be started</returns>
        public bool TryToStart(Key bikeKey)
        {
            if (this.BikeKey.KeyMatches(bikeKey))
            {
                this.Start();
                return true;
            }

            // Key didn't match
            return false;
        }

        /// <summary>
        /// Shutoff the motorcycle
        /// </summary>
        /// <returns>The motorcycle key</returns>
        public Key Shutoff()
        {
            this.SwitchOff();
            return this.BikeKey;
        }

        /// <summary>
        /// Try to kickstart an electic start motorcycle
        /// </summary>
        public override void Kickstart()
        {
            Console.WriteLine("Fancy motorcycles use electric starters, kickstart will not start motorcycles");
        }

        /// <summary>
        /// Description of the fancy motorcycle
        /// </summary>
        /// <returns>A description of the fancy motorcycle</returns>
        public override string GetDescription()
        {
            return string.Format("{0} and {1} motorcycle, tops out at {2} mph", this.Color.ToString(), this.SecondaryColor.ToString(), this.MaxSpeed);
        }
    }
}
