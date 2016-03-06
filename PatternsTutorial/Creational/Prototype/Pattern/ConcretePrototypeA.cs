// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcretePrototypeA.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The concrete prototype a.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.Prototype.Pattern
{
    /// <summary>
    /// The concrete prototype a.
    /// </summary>
    internal class ConcretePrototypeA : Prototype
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcretePrototypeA"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        public ConcretePrototypeA(string id)
            : base(id)
        {
        }
         
        /// <summary>
        /// The clone.
        /// </summary>
        /// <returns>
        /// The <see cref="Prototype"/>.
        /// </returns>
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
