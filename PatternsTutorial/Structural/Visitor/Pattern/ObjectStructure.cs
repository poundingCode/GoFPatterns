// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectStructure.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'ObjectStructure' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Visitor.Pattern
{
    using System.Collections.Generic;

    /// <summary>
    /// The 'ObjectStructure' class
    /// </summary>
    internal class ObjectStructure
    {
        /// <summary>
        /// The _elements.
        /// </summary>
        private readonly List<Element> _elements = new List<Element>();

        /// <summary>
        /// The attach.
        /// </summary>
        /// <param name="element">
        /// The element.
        /// </param>
        public void Attach(Element element)
        {
            this._elements.Add(element);
        }

        /// <summary>
        /// The detach.
        /// </summary>
        /// <param name="element">
        /// The element.
        /// </param>
        public void Detach(Element element)
        {
            this._elements.Remove(element);
        }

        /// <summary>
        /// The accept.
        /// </summary>
        /// <param name="visitor">
        /// The visitor.
        /// </param>
        public void Accept(Visitor visitor)
        {
            foreach (var element in this._elements)
            {
                element.Accept(visitor);
            }
        }
    }
}