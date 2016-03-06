// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NeapolitanStylePizza.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Provides a concrete implemintation of the pizza class for NeapolitanStylePizza.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.FactoryMethod.Expanded
{
    using System.Collections.Generic;

    /// <summary>
    /// Provides a concrete implemintation of the pizza class for NeapolitanStylePizza.
    /// </summary>
    public class NeapolitanStylePizza : IPizza
    {
        /// <summary>
        /// The ingredients.
        /// </summary>
        private readonly List<string> ingredients = new List<string> { "dough" };

        /// <summary>
        /// Initializes a new instance of the <see cref="NeapolitanStylePizza"/> class.
        /// </summary>
        public NeapolitanStylePizza()
        {
            this.ingredients.Add("san marzano tomatoes");
            this.ingredients.Add("handmade mozzerella");
            this.ingredients.Add("basil");
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
            get { return "A nice Chianti!"; }
        }
    }
}