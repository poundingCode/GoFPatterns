// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteCreator.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The concrete creator.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.FactoryMethod.Pattern
{
    /// <summary>
    /// The concrete creator.
    /// </summary>
    public class ConcreteCreator : Creator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteCreator"/> class.
        /// </summary>
        public ConcreteCreator()
        {
        }

        /// <summary>
        /// The factory method.
        /// </summary>
        /// <returns>
        /// The <see cref="IProduct"/>.
        /// </returns>
        protected override IProduct FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}