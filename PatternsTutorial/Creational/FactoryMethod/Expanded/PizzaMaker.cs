// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PizzaMaker.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Abstract PizzaMaker class from which certain makers will be defined.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.FactoryMethod.Expanded
{
    using System;

    /// <summary>
    /// Abstract PizzaMaker class from which certain makers will be defined.
    /// </summary>
    public abstract class PizzaMaker
    {
        /// <summary>
        /// The place order.
        /// </summary>
        public void PlaceOrder()
        {
            Console.Write("Somebody wants a pizza ");
            this.MakePizza();
        }

        /// <summary>
        /// Gets or sets the bake time in minutes.
        /// </summary>
        public int BakeTimeInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the temperature.
        /// </summary>
        public int Temperature { get; set; }

        /// <summary>
        /// The make pizza.
        /// </summary>
        protected abstract void MakePizza();

        /// <summary>
        /// The deliver pizza.
        /// </summary>
        /// <returns>
        /// The <see cref="IPizza"/>.
        /// </returns>
        public abstract IPizza DeliverPizza();
    }
}