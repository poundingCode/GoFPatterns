// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Caretaker.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'Caretaker' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Memento.Pattern
{
    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    internal class Caretaker
    {
        /// <summary>
        /// The _memento
        /// </summary>
        private Memento memento;

        /// <summary>
        /// Gets or sets the memento.
        /// </summary>
        /// <value>The memento.</value>
        internal Memento Memento
        {
            get { return this.memento; }
            set { this.memento = value; }
        }
    }
}