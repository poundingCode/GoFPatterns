// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteVisitor2.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   A 'ConcreteVisitor' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Visitor.Pattern
{
    using System;

    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    internal class ConcreteVisitor2 : Visitor
    {
        /// <summary>
        /// The visit concrete element a.
        /// </summary>
        /// <param name="concreteElementA">
        /// The concrete element a.
        /// </param>
        public override void VisitConcreteElementA(
            ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visited by {1}",  concreteElementA.GetType().Name, this.GetType().Name);
        }

        /// <summary>
        /// The visit concrete element b.
        /// </summary>
        /// <param name="concreteElementB">
        /// The concrete element b.
        /// </param>
        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visited by {1}", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}