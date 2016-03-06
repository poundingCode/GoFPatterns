// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChicagoStylePizza.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Provides a concrete implementation of the pizza class for ChicagoStylePizza.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.FactoryMethod.Expanded
{
    using System.Collections.Generic;

    /// <summary>
    /// Provides a concrete implementation of the pizza class for ChicagoStylePizza.
    /// </summary>
    public class ChicagoStylePizza : IPizza
    {
        /// <summary>
        /// The ingredients.
        /// </summary>
        private readonly List<string> ingredients = new List<string> { "dough" };

        /// <summary>
        /// Initializes a new instance of the <see cref="ChicagoStylePizza"/> class.
        /// </summary>
        public ChicagoStylePizza()
        {
            this.ingredients.Add("cheese");
            this.ingredients.Add("sauce");
            this.ingredients.Add("pepperoni");
            this.ingredients.Add("peppers");
            this.ingredients.Add("onions");
            this.ingredients.Add("dough");
            this.ingredients.Add("sauce");
            this.ingredients.Add("cheese");
        }

        /// <summary>
        /// Gets the ingredients.
        /// </summary>
        public List<string> Ingredients
        {
            get { return this.ingredients; }
        }

        /// <summary>
        /// Gets the best served with.
        /// </summary>
        public string BestServedWith
        {
            get { return "Draft Beer!"; }
        }
    }
}