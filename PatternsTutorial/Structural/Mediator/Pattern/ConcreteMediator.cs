// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteMediator.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class ConcreteMediator.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Mediator.Pattern
{
    /// <summary>
    /// Class ConcreteMediator.
    /// </summary>
    internal class ConcreteMediator : Mediator
    {
        /// <summary>
        /// The _colleague1
        /// </summary>
        private ConcreteColleague1 _colleague1;

        /// <summary>
        /// The _colleague2
        /// </summary>
        private ConcreteColleague2 _colleague2;

        /// <summary>
        /// Sets the colleague1.
        /// </summary>
        /// <value>The colleague1.</value>
        internal ConcreteColleague1 Colleague1
        {
            set
            {
                _colleague1 = value;
            }
        }

        /// <summary>
        /// Sets the colleague2.
        /// </summary>
        /// <value>The colleague2.</value>
        internal ConcreteColleague2 Colleague2
        {
            set
            {
                _colleague2 = value;
            }
        }

        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="colleague">
        /// The colleague.
        /// </param>
        internal override void Send(string message, Colleague colleague)
        {
            if (colleague == _colleague1)
            {
                _colleague2.Notify(message);
            }
            else
            {
                _colleague1.Notify(message);
            }
        }
    }
}
