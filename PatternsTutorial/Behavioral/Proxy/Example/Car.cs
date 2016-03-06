// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Car.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The car.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Behavioral.Proxy.Example
{
    using System;

    /// <summary>
    /// The car.
    /// </summary>
    internal class Car : ICar
   {
        /// <summary>
        /// Gets or sets the current speed.
        /// </summary>
        /// <value>The current speed.</value>
        public int CurrentSpeed { get; set; }

        /// <summary>
        /// Travels this instance.
        /// </summary>
        public void Travel()
        {
            Console.WriteLine("Car is traveling at " + this.CurrentSpeed);
        }
    }
}
