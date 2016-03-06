// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoker.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class Invoker.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Command.Pattern
{
    /// <summary>
    /// Class Invoker.
    /// </summary>
    internal class Invoker
    {
        /// <summary>
        /// The _command
        /// </summary>
        private Command command;

        /// <summary>
        /// Sets the command.
        /// </summary>
        /// <param name="commandToSet">
        /// The command.
        /// </param>
        internal void SetCommand(Command commandToSet)
        {
            this.command = commandToSet;
        }

        /// <summary>
        /// Executes the command.
        /// </summary>
        internal void ExecuteCommand()
        {
            this.command.Execute();
        }
    }
}
