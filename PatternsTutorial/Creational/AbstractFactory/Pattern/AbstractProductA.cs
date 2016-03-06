// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AbstractProductA.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The abstract product a.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.AbstractFactory.Pattern
{
    /// <summary>
    /// The abstract product a.
    /// </summary>
    public abstract class AbstractProductA
    {
        /// <summary>
        /// The interact.
        /// </summary>
        /// <param name="b">
        /// The b.
        /// </param>
        public abstract void Interact(AbstractProductB b);
    }
}
