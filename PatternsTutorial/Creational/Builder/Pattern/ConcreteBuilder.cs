// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteBuilder.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The concrete builder.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.Builder.Pattern
{
    /// <summary>
    /// The concrete builder.
    /// </summary>
    internal class ConcreteBuilder : Builder
    {
        /// <summary>
        /// The _product.
        /// </summary>
        private readonly Product _product = new Product();

        /// <summary>
        /// The build part.
        /// </summary>
        public override void BuildPart()
        {
           this._product.Add("PartA");
        }

        /// <summary>
        /// The get result.
        /// </summary>
        /// <returns>
        /// The <see cref="Product"/>.
        /// </returns>
        public override Product GetResult()
        {
            return _product;
        }
    }
}
