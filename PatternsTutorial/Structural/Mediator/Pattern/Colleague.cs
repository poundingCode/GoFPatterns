// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Colleague.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class Colleague.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Mediator.Pattern
{
    /// <summary>
    /// Class Colleague.
    /// </summary>
    internal abstract class Colleague
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Colleague"/> class.
        /// </summary>
        /// <param name="mediator">
        /// The mediator.
        /// </param>
        internal Colleague(Mediator mediator)
        {
            this.Mediator = mediator;
        }

        /// <summary>
        /// The mediator
        /// </summary>
        protected Mediator Mediator { get; set; }
    }
}
