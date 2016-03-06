// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProxyCar.cs" "  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The proxy car.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System; 

namespace PatternsTutorial.Behavioral.Proxy.Example
{
    /// <summary>
    /// The proxy car.
    /// </summary>
    internal class ProxyCar : ICar
    {
        /// <summary>
        /// The driver.
        /// </summary>
        private Driver driver;

        /// <summary>
        /// The real car.
        /// </summary>
        private ICar realCar;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyCar"/> class.
        /// </summary>
        /// <param name="driver">
        /// The driver.
        /// </param>
        public ProxyCar(Driver driver)
        {
            this.driver = driver;
            this.realCar = new Car();
        }

        /// <summary>
        /// Travels this instance.
        /// </summary>
        public void Travel()
        {
            if (this.driver.Age <= 16)
            {
                Console.WriteLine("Sorry the driver is too young to drive");
            }
            else
            {
                this.realCar.Travel();
            }
        }

        /// <summary>
        /// Gets or sets the current speed.
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public int CurrentSpeed { get; set; }
    }
}
