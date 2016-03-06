// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteFactory2.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The concrete factory 2.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.AbstractFactory.Pattern
{
    using System;

    /// <summary>
    /// The concrete factory 2.
    /// </summary>
    public class ConcreteFactory2 : AbstractFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteFactory2"/> class.
        /// </summary>
        public ConcreteFactory2()
        {
            Console.WriteLine("ConcreteFactory2 created");
        }

        /// <summary>
        /// The create product a.
        /// </summary>
        /// <returns>
        /// The <see cref="AbstractProductA"/>.
        /// </returns>
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        /// <summary>
        /// The create product b.
        /// </summary>
        /// <returns>
        /// The <see cref="AbstractProductB"/>.
        /// </returns>
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
