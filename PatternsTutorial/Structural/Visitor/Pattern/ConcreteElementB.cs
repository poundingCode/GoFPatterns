// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteElementB.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   A 'ConcreteElement' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Visitor.Pattern
{
    /// <summary>
    /// A 'ConcreteElement' class
    /// </summary>
    internal class ConcreteElementB : Element
    {
        /// <summary>
        /// The accept.
        /// </summary>
        /// <param name="visitor">
        /// The visitor.
        /// </param>
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        /// <summary>
        /// The operation b.
        /// </summary>
        public void OperationB()
        {
        }
    }
}