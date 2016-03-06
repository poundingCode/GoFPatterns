// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Creator.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The creator.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.FactoryMethod.Pattern
{
    using System;

    /// <summary>
    /// The creator.
    /// </summary>
    public abstract class Creator
    {
        /// <summary>
        /// The create operation.
        /// </summary>
        public void CreateOperation()
        {
            Console.WriteLine("Creator.CreateOperation called");
            var product = this.FactoryMethod();
        }

        /// <summary>
        /// The factory method.
        /// </summary>
        /// <returns>
        /// The <see cref="IProduct"/>.
        /// </returns>
        protected abstract IProduct FactoryMethod();
    }
}