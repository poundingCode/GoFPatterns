// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteStrategyA.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   A 'ConcreteStrategy' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Strategy.Pattern
{
    using System;

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    internal class ConcreteStrategyA : Strategy
    {
        /// <summary>
        /// The algorithm interface.
        /// </summary>
        internal override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }
}