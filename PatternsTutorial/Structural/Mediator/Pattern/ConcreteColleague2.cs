// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteColleague2.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class ConcreteColleague2.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Mediator.Pattern
{
    using System;

    /// <summary>
    /// Class ConcreteColleague2.
    /// </summary>
    internal class ConcreteColleague2 : Colleague
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteColleague2"/> class.
        /// </summary>
        /// <param name="mediator">
        /// The mediator.
        /// </param>
        internal ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        internal void Send(string message)
        {
            this.Mediator.Send(message, this);
        }

        /// <summary>
        /// Notifies the specified message.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        internal void Notify(string message)
        {
            Console.WriteLine("Colleague2 gets message: " + message);
        }
    }
}
