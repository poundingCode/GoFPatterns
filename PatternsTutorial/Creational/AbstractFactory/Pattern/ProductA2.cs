// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductA2.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The product a 2.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.AbstractFactory.Pattern
{
    using System;

    /// <summary>
    /// The product a 2.
    /// </summary>
    internal class ProductA2 : AbstractProductA
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductA2"/> class.
        /// </summary>
        internal ProductA2()
        {
            Console.WriteLine("ProductA2 created");
        }

        /// <summary>
        /// The interact.
        /// </summary>
        /// <param name="b">
        /// The b.
        /// </param>
        public override void Interact(AbstractProductB b)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + b.GetType().Name);
        }
    }
}
