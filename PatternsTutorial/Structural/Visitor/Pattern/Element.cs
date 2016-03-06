// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Element.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'Element' abstract class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Visitor.Pattern
{
    /// <summary>
    /// The 'Element' abstract class
    /// </summary>
    internal abstract class Element
    {
        /// <summary>
        /// The accept.
        /// </summary>
        /// <param name="visitor">
        /// The visitor.
        /// </param>
        public abstract void Accept(Visitor visitor);
    }
}