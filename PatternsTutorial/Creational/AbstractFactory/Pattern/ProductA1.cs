﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductA1.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The product a 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.AbstractFactory.Pattern
{
    using System;

    /// <summary>
    /// The product a 1.
    /// </summary>
    internal class ProductA1 : AbstractProductA
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductA1"/> class.
        /// </summary>
        internal ProductA1()
        {
            Console.WriteLine("ProductA1 created");
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
