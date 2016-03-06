// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteProduct.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The concrete product.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.FactoryMethod.Pattern
{
    using System;

    /// <summary>
    /// The concrete product.
    /// </summary>
    public class ConcreteProduct : IProduct
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteProduct"/> class.
        /// </summary>
        public ConcreteProduct()
        {
            Console.WriteLine("A FactoryMethod ConcreteProduct created");
        }
    }
}