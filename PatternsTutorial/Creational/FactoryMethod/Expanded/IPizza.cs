// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPizza.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The Pizza interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.FactoryMethod.Expanded
{
    using System.Collections.Generic;

    /// <summary>
    /// The Pizza interface.
    /// </summary>
    public interface IPizza
        {
        /// <summary>
        /// Gets the ingredients.
        /// </summary>
        List<string> Ingredients { get; }

        /// <summary>
        /// Gets the best served with.
        /// </summary>
        string BestServedWith { get; }
        }
}