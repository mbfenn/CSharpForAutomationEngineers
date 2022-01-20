
namespace Vehicle.VehicleTypes
{
    /// <summary>
    /// The abstract concept of a vehicle
    /// </summary>
    public abstract class AbstractVehicle
    {
        /// <summary>
        /// If the vehicle is started
        /// </summary>
        private bool Started = false;

        /// <summary>
        /// Primary color
        /// </summary>
        public Color Color { get; private set; }

        /// <summary>
        /// Maximum speed in MPH
        /// </summary>
        public double MaxSpeed { get; private set; }

        /// <summary>
        /// Number of tires on the vehicle
        /// </summary>
        public abstract int NumberOfTires { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="color">Primary color</param>
        /// <param name="maxSpeed">Maximum speed in MPH</param>
        public AbstractVehicle(Color color, double maxSpeed)
        {
            this.Color = color;
            this.MaxSpeed = maxSpeed;
        }
        
        /// <summary>
        /// Description of the vehicle
        /// </summary>
        /// <returns>A description of the vehicle</returns>
        public abstract string GetDescription();

        /// <summary>
        /// Check if the vehicle is stared
        /// </summary>
        /// <returns>True if the vehicle is started</returns>
        public bool IsStated()
        {
            return Started;
        }

        /// <summary>
        /// Start the vehicle
        /// </summary>
        protected void Start()
        {
            Started = true;
        }

        /// <summary>
        /// Stop the vehicle
        /// </summary>
        protected void Stop()
        {
            Started = false;
        }
    }
}
