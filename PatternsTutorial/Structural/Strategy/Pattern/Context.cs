// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Context.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'Context' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Strategy.Pattern
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    internal class Context
    {
        /// <summary>
        /// The _strategy.
        /// </summary>
        private readonly Strategy _strategy;

        /// <summary>
        /// Initializes a new instance of the <see cref="Context"/> class.
        /// </summary>
        /// <param name="strategy">
        /// The strategy.
        /// </param>
        internal Context(Strategy strategy)
        {
            this._strategy = strategy;
        }

        /// <summary>
        /// The context interface.
        /// </summary>
        internal void ContextInterface()
        {
            this._strategy.AlgorithmInterface();
        }
    }
}