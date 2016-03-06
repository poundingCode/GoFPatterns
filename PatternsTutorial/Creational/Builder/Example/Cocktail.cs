// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cocktail.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The cocktail.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.Builder.Example
{
    using System.Collections.Generic;

    /// <summary>
    /// The cocktail.
    /// </summary>
    internal class Cocktail
    {
        /// <summary>
        /// Gets or sets the glass.
        /// </summary>
        public string Glass { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether ice.
        /// </summary>
        public bool Ice { get; set; }

        /// <summary>
        /// Gets or sets the spirits.
        /// </summary>
        public List<Ingredient> Spirits { get; set; }

        /// <summary>
        /// Gets or sets the mixers.
        /// </summary>
        public List<Ingredient> Mixers { get; set; }

        /// <summary>
        /// Gets or sets the spices.
        /// </summary>
        public List<Ingredient> Spices { get; set; }

        /// <summary>
        /// Gets or sets the garnishes.
        /// </summary>
        public List<Ingredient> Garnishes { get; set; }
    }
}
