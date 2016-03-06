// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcretePrototypeB.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The concrete prototype b.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.Prototype.Pattern
{
    /// <summary>
    /// The concrete prototype b.
    /// </summary>
    internal class ConcretePrototypeB : Prototype
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcretePrototypeB"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        public ConcretePrototypeB(string id) : base(id)
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
