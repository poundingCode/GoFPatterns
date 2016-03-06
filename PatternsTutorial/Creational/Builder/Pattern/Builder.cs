// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Builder.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The builder.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.Builder.Pattern
{
    /// <summary>
    /// The builder.
    /// </summary>
    internal abstract class Builder
    {
        /// <summary>
        /// The build part.
        /// </summary>
        public abstract void BuildPart();

        /// <summary>
        /// The get result.
        /// </summary>
        /// <returns>
        /// The <see cref="Product"/>.
        /// </returns>
        public abstract Product GetResult();
    }
}
