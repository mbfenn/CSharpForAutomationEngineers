using System;

namespace Vehicle.VehicleTypes
{
    /// <summary>
    /// A motorcycle
    /// </summary>
    public class Motorcycle : AbstractVehicle
    {
        /// <summary>
        /// Is the on switch on
        /// </summary>
        protected bool OnSwitchOn = false;

        /// <summary>
        /// The number of tires
        /// </summary>
        public override int NumberOfTires
        {
            get { return 2; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="color">Primary color</param>
        public Motorcycle(Color color) : base(color, 60)
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="color">Primary color</param>
        /// <param name="topSpeed">Top speed in MPH</param>
        public Motorcycle(Color color, double topSpeed) : base(color, topSpeed)
        {

        }

        /// <summary>
        /// Start the motorcycle with the kickstarter
        /// </summary>
        public virtual void Kickstart()
        {
            if (this.IsStated())
            {
                Console.WriteLine("Motorcycle is already started");
            }
            else
            {
                OnSwitchOn = true;
                this.Start();
                Console.WriteLine("Motorcycle started");
            }
        }

        /// <summary>
        /// Switch off the motorcycle
        /// </summary>
        public void SwitchOff()
        {
            if (!this.IsStated())
            {
                Console.WriteLine("Motorcycle is not started");
            }
            else
            {
                OnSwitchOn = false;
                this.Stop();
                Console.WriteLine("Motorcycle stopped");
            }
        }

        /// <summary>
        /// Description of the motorcycle
        /// </summary>
        /// <returns>A description of the motorcycle</returns>
        public override string GetDescription()
        {
            return string.Format("{0} motorcycle, tops out at {1} mph", this.Color.ToString(), this.MaxSpeed);
        }
    }
}
