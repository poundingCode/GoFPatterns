// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Abstraction.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'Abstraction' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Composite.Pattern
{
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
  internal class Abstraction
  {
        /// <summary>
        /// Sets the implementor.
        /// </summary>
        public Implementor Implementor
        {
          set { this.implementor = value; }
        }

        /// <summary>
        /// Gets or sets the implementor.
        /// </summary>
        /// <value>The implementor.</value>
        internal Implementor implementor { get; set; }

        /// <summary>
        /// The operation.
        /// </summary>
        public virtual void Operation()
        {
            this.implementor.Operation();
        }
  }
}
