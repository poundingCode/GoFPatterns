// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Ingredient.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The ingredient.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.Builder.Example
{
    /// <summary>
    /// The ingredient.
    /// </summary>
    internal class Ingredient
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        internal string Name { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        internal double Quantity { get; set; }

        /// <summary>
        /// Gets or sets the measurement.
        /// </summary>
        internal string Measurement { get; set; }
    }
}
