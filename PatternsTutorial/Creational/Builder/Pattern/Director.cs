// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Director.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The director.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.Builder.Pattern
{
    /// <summary>
    /// The director.
    /// </summary>
    internal class Director
    {
        /// <summary>
        /// The construct.
        /// </summary>
        /// <param name="builder">
        /// The builder.
        /// </param>
        public void Construct(Builder builder)
        {
            builder.BuildPart();
        }
    }
}
