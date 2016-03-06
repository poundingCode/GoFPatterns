// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pizzeria.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The pizzeria.
    // The Creator: (also referred to as the factory) declares the method Factory Method, 
    // which returns a Product object. May call the generating method for creating Product objects
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.FactoryMethod.Example
{
    /// <summary>
    /// The pizzeria.
    /// </summary>
    public abstract class Pizzeria
    {
        /// <summary>
        /// The pizza maker.
        /// </summary>
        public void PizzaMaker()
        {
            var pizza = this.MakePizza();
        }

        /// <summary>
        /// Abstract method for making the pizza.
        /// </summary>
        /// <returns>I Pizza.</returns>
        protected abstract IPizza MakePizza();
    }
}