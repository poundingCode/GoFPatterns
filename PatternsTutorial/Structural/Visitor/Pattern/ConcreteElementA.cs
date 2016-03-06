// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteElementA.cs"  company="James Fleming">
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
    internal class ConcreteElementA : Element
    {
        /// <summary>
        /// The accept.
        /// </summary>
        /// <param name="visitor">
        /// The visitor.
        /// </param>
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        /// <summary>
        /// The operation a.
        /// </summary>
        public void OperationA()
        {
        }
    }
}