// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Supporter.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The supporter.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Behavioral.Composite.Example
{
    /// <summary>
    /// The supporter.
    /// </summary>
    internal class Supporter : Person 
    {
        /// <summary>
        /// Gets or sets the contribution.
        /// </summary>
        public int Contribution { get; set; }

        /// <summary>
        /// Gets or sets the affiliation.
        /// </summary>
        public string Affiliation { get; set; }
    }
}
