// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Observer.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'Observer' abstract class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Observer.Pattern
{
    /// <summary>
    /// The 'Observer' abstract class
    /// </summary>
    internal abstract class Observer
    {
        /// <summary>
        /// The update.
        /// </summary>
        internal abstract void Update();
    }
}