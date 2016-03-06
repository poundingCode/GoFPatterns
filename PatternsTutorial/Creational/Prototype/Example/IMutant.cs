// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMutant.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The Mutant interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.Prototype.Example
{
    /// <summary>
    /// The Mutant interface.
    /// </summary>
    public interface IMutant
    {
        /// <summary>
        /// Gets or sets the character.
        /// </summary>
        string Character { get; set; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets or sets the mutation.
        /// </summary>
        Mutation Mutation {get; set; }

        /// <summary>
        /// The shallow copy.
        /// </summary>
        /// <returns>
        /// The <see cref="IMutant"/>.
        /// </returns>
        IMutant ShallowCopy();

        /// <summary>
        /// The deep copy.
        /// </summary>
        /// <returns>
        /// The <see cref="IMutant"/>.
        /// </returns>
        IMutant DeepCopy();
    }
}
