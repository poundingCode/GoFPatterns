// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Defines the Invoke type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Strategy
{
    using System;

    using PatternsTutorial.Structural.Strategy.Pattern;

    /// <summary>
    /// Class Invoke.
    /// </summary>
    public static class Invoke
    {
        /// <summary>
        /// The execute.
        /// </summary>
        public static void Samples()
        {
            Pattern();
            Example();
        }

        /// <summary>
        /// The pattern.
        /// </summary>
        private static void Pattern()
        {
            Console.WriteLine("Invoking the  Pattern...");
            Console.WriteLine("I ");

            Context context;

            // Three contexts following different strategies
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
        }

        /// <summary>
        /// The example.
        /// </summary>
        private static void Example()
        {
            Console.WriteLine("TODO the  example...");
        }
    }
}
