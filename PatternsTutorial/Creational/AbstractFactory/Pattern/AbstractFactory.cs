// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AbstractFactory.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class AbstractFactory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.AbstractFactory.Pattern
{
    /// <summary>
    /// Class AbstractFactory.
    /// </summary>
    public abstract class AbstractFactory
    {
        /// <summary>
        /// Creates the product a.
        /// </summary>
        /// <returns>Abstract Product A.</returns>
        public abstract AbstractProductA CreateProductA();

        /// <summary>
        /// Creates the product b.
        /// </summary>
        /// <returns>Abstract Product B.</returns>
        public abstract AbstractProductB CreateProductB();
    }
}
