// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Iterator.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'Iterator' abstract class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Iterator.Pattern
{
    /// <summary>
    /// The 'Iterator' abstract class
    /// </summary>
    internal abstract class Iterator
    {
        /// <summary>
        /// Firsts this instance.
        /// </summary>
        /// <returns>System.Object.</returns>
        internal abstract object First();

        /// <summary>
        /// Nexts this instance.
        /// </summary>
        /// <returns>System.Object.</returns>
        internal abstract object Next();

        /// <summary>
        /// Determines whether this instance is done.
        /// </summary>
        /// <returns><c>true</c> if this instance is done; otherwise, <c>false</c>.</returns>
        internal abstract bool IsDone();

        /// <summary>
        /// Currents the item.
        /// </summary>
        /// <returns>System.Object.</returns>
        internal abstract object CurrentItem();
    }
}