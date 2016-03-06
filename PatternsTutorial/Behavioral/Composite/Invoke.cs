// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Composite lets clients treat individual objects and compositions of objects uniformly.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Composite
{
    using System;

    using PatternsTutorial.Behavioral.Composite.Example;
    using PatternsTutorial.Behavioral.Composite.Pattern;

    /// <summary>
    /// Composite lets clients treat individual objects and compositions of objects uniformly.
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
        /// Patterns this instance.
        /// </summary>
        private static void Pattern()
        {
            Console.WriteLine("Invoking the Composite Pattern...");
            Console.WriteLine("I Match interfaces of different classes");

            Abstraction ab = new RefinedAbstraction();
 
            // Set implementation and call
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();
 
            // Change implementation and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
        }

        /// <summary>
        /// Examples this instance.
        /// </summary>
        private static void Example()
        {
            Console.WriteLine("Invoking the Composite example...");

            var election = new Election();
            election.HoldPrimary();
            election.HoldElection();
        }
    }
}
