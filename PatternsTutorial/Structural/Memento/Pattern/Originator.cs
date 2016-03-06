// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Originator.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'Originator' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Memento.Pattern
{
    using System;

    /// <summary>
    /// The 'Originator' class
    /// </summary>
    internal class Originator
    {
        /// <summary>
        /// The state
        /// </summary>
        private string state;

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        internal string State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.state = value;
                Console.WriteLine("State = " + this.state);
            }
        }

        /// <summary>
        /// Creates the memento.
        /// </summary>
        /// <returns>The Memento.</returns>
        internal Memento CreateMemento()
        {
            return new Memento(this.state);
        }

        /// <summary>
        /// Sets the memento.
        /// </summary>
        /// <param name="memento">
        /// The memento.
        /// </param>
        internal void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            this.State = memento.State;
        }
    }
}
