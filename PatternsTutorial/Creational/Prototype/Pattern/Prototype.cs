// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Prototype.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The prototype.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.Prototype
{
    /// <summary>
    /// The prototype.
    /// </summary>
    internal abstract class Prototype
    {
        /// <summary>
        /// The id.
        /// </summary>
        private readonly string id;
         
        /// <summary>
        /// Initializes a new instance of the <see cref="Prototype"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        public Prototype(string id)
        {
            this.id = id;
        }
         
        /// <summary>
        /// Gets the id.
        /// </summary>
        public string Id
        {
            get { return this.id; }
        }

        /// <summary>
        /// The clone.
        /// </summary>
        /// <returns>
        /// The <see cref="Prototype"/>.
        /// </returns>
        public abstract Prototype Clone();
    }
}
