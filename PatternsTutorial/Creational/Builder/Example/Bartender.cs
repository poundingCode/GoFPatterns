// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bartender.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The bartender.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.Builder.Example
{
    using System;

    /// <summary>
    /// The bartender.
    /// </summary>
    internal class Bartender
    {
        /// <summary>
        /// The make cocktail.
        /// </summary>
        /// <param name="buildCocktail">
        /// The build cocktail.
        /// </param>
        internal void MakeCocktail(CocktailBuilder buildCocktail)
        {
            buildCocktail.GetGlass();
            buildCocktail.AddIce();
            buildCocktail.AddSpirits();
            buildCocktail.AddMixers();
            buildCocktail.AddSpices();
            buildCocktail.AddGarnishes();

            Console.WriteLine(buildCocktail.Name);
            buildCocktail.MixDrink();
        }
    }
}
