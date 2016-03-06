// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mutation.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The mutation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace PatternsTutorial.Creational.Prototype.Example
{
    /// <summary>
    /// The mutation.
    /// </summary>
    public class Mutation
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the powers.
        /// </summary>
        public List<string> Powers { get; set; }
    }
}
