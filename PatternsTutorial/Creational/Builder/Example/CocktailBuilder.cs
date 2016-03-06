// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CocktailBuilder.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The cocktail builder.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.Builder.Example
{
    /// <summary>
    /// The cocktail builder.
    /// </summary>
    internal abstract class CocktailBuilder
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// The get glass.
        /// </summary>
        public abstract void GetGlass();

        /// <summary>
        /// The add ice.
        /// </summary>
        public abstract void AddIce();

        /// <summary>
        /// The add spirits.
        /// </summary>
        public abstract void AddSpirits();

        /// <summary>
        /// The add mixers.
        /// </summary>
        public abstract void AddMixers();

        /// <summary>
        /// The add spices.
        /// </summary>
        public abstract void AddSpices();

        /// <summary>
        /// The add garnishes.
        /// </summary>
        public abstract void AddGarnishes();

        /// <summary>
        /// The mix drink.
        /// </summary>
        public abstract void MixDrink();
    }
}
