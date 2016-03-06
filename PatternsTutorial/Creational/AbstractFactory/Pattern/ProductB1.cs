// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductB1.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The product b 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.AbstractFactory.Pattern
{
    using System;

    /// <summary>
    /// The product b 1.
    /// </summary>
    internal class ProductB1 : AbstractProductB
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductB1"/> class.
        /// </summary>
        internal ProductB1()
        {
            Console.WriteLine("ProductB1 created");
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
