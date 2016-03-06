// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mediator.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class Mediator.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Mediator.Pattern
{
    /// <summary>
    /// Class Mediator.
    /// </summary>
    internal abstract class Mediator
    {
        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="colleague">
        /// The colleague.
        /// </param>
        internal abstract void Send(string message, Colleague colleague);
    }
}
