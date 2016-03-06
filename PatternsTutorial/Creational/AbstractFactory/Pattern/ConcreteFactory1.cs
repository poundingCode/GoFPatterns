// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteFactory1.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The concrete factory 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.AbstractFactory.Pattern
{
    using System;

    /// <summary>
    /// The concrete factory 1.
    /// </summary>
    public class ConcreteFactory1 : AbstractFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteFactory1"/> class.
        /// </summary>
        public ConcreteFactory1()
        {
            Console.WriteLine("ConcreteFactory1 created");
        }

        /// <summary>
        /// The create product a.
        /// </summary>
        /// <returns>
        /// The <see cref="AbstractProductA"/>.
        /// </returns>
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        /// <summary>
        /// The create product b.
        /// </summary>
        /// <returns>
        /// The <see cref="AbstractProductB"/>.
        /// </returns>
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
