// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The product.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.Builder.Pattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The product.
    /// </summary>
    internal class Product
    {
        /// <summary>
        /// The parts.
        /// </summary>
        private readonly List<string> parts = new List<string>();

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="part">
        /// The part.
        /// </param>
        public void Add(string part)
        {
            this.parts.Add(part);
        }

        /// <summary>
        /// The show.
        /// </summary>
        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach (var part in this.parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
