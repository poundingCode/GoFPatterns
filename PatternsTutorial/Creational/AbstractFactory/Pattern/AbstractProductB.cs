// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AbstractProductB.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The abstract product b.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.AbstractFactory.Pattern
{
    /// <summary>
    /// The abstract product b.
    /// </summary>
    public abstract class AbstractProductB
    {
        /// <summary>
        /// The interact.
        /// </summary>
        /// <param name="a">
        /// The a.
        /// </param>
        public abstract void Interact(AbstractProductA a);
    }
}
