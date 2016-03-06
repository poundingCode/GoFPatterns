// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PizzaShop.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The concrete creator overrides the generating method for creating ConcreteProduct objects
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.FactoryMethod.Example
{
    /// <summary>
    /// The concrete creator overrides the generating method for creating ConcreteProduct objects 
    /// </summary>
    public class PizzaShop : Pizzeria
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PizzaShop"/> class.
        /// </summary>
        public PizzaShop()
        {
        }

        /// <summary>
        /// The make pizza.
        /// </summary>
        /// <returns>
        /// The <see cref="IPizza"/>.
        /// </returns>
        protected override IPizza MakePizza()
        {
            return new Pizza();
        }
    }
}