// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteCommand.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class ConcreteCommand.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Command.Pattern
{
    /// <summary>
    /// Class ConcreteCommand.
    /// </summary>
    internal class ConcreteCommand : Command
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteCommand"/> class.
        /// </summary>
        /// <param name="receiver">
        /// The receiver.
        /// </param>
        internal ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        /// <summary>
        /// Executes this instance.
        /// </summary>
        internal override void Execute()
        {
            this.Receiver.Action();
        }
    }
}
