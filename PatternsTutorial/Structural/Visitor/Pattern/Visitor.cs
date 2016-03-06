// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Visitor.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'Visitor' abstract class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Visitor.Pattern
{
    /// <summary>
    /// The 'Visitor' abstract class
    /// </summary>
    internal abstract class Visitor
    {
        /// <summary>
        /// The visit concrete element a.
        /// </summary>
        /// <param name="concreteElementA">
        /// The concrete element a.
        /// </param>
        public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);

        /// <summary>
        /// The visit concrete element b.
        /// </summary>
        /// <param name="concreteElementB">
        /// The concrete element b.
        /// </param>
        public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);
    }
}
