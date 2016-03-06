// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductB2.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The product b 2.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.AbstractFactory.Pattern
{
    using System;

    /// <summary>
    /// The product b 2.
    /// </summary>
    internal class ProductB2 : AbstractProductB
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductB2"/> class.
        /// </summary>
        internal ProductB2()
        {
            Console.WriteLine("ProductB2 created");
        }

        /// <summary>
        /// The interact.
        /// </summary>
        /// <param name="a">
        /// The a.
        /// </param>
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }
}
