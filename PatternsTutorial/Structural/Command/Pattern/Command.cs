// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Command.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class Command.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Command.Pattern
{
    /// <summary>
    /// Class Command.
    /// </summary>
    internal abstract class Command
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Command"/> class.
        /// </summary>
        /// <param name="receiver">
        /// The receiver.
        /// </param>
        internal Command(Receiver receiver)
        {
            this.Receiver = receiver;
        }

        /// <summary>
        /// Gets the receiver.
        /// </summary>
        /// <value>The receiver.</value>
        protected Receiver Receiver { get; private set; }

        /// <summary>
        /// Executes this instance.
        /// </summary>
        internal abstract void Execute();
    }
}
