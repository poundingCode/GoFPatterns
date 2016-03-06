// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Driver.cs"  company="James Fleming">
//   poundingCode@gmail.com//   
// </copyright>
// <summary>
//   The driver.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Behavioral.Proxy.Example
{
    /// <summary>
    /// The driver.
    /// </summary>
    internal class Driver
    {
        /// <summary>
        /// The age.
        /// </summary>
        private int age;

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>The age.</value>
        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Driver"/> class.
        /// </summary>
        /// <param name="age">
        /// The age.
        /// </param>
        public Driver(int age)
        {
            this.age = age;
        }
    }
}
