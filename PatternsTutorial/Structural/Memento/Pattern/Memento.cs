// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Memento.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'Memento' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Memento.Pattern
{
    /// <summary>
    /// The 'Memento' class
    /// </summary>
    internal class Memento
    {
        /// <summary>
        /// The _state
        /// </summary>
        private readonly string _state;

        /// <summary>
        /// Initializes a new instance of the <see cref="Memento"/> class.
        /// </summary>
        /// <param name="state">
        /// The state.
        /// </param>
        public Memento(string state)
        {
            this._state = state;
        }
         
        /// <summary>
        /// Gets the state.
        /// </summary>
        /// <value>The state.</value>
        public string State
        {
            get { return this._state; }
        }
    }
}