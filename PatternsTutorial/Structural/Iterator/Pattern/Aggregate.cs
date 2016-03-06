// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Aggregate.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'Aggregate' abstract class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Iterator.Pattern
{
    /// <summary>
    /// The 'Aggregate' abstract class
    /// </summary>
    internal abstract class Aggregate
    {
        /// <summary>
        /// The create iterator.
        /// </summary>
        /// <returns>
        /// The <see cref="Iterator"/>.
        /// </returns>
        public abstract Iterator CreateIterator();
    }
}
