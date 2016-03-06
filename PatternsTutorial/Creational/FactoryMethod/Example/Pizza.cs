// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pizza.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The concrete product.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.FactoryMethod.Example
{
    using System;

    /// <summary>
    /// The concrete product.
    /// </summary>
    public class Pizza : IPizza
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pizza"/> class.
        /// </summary>
        public Pizza()
        {
            Console.WriteLine("Pizza!");
        }
    }
}