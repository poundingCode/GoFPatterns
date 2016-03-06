// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Defines the Invoke type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Observer
{
    using System;

    using PatternsTutorial.Structural.Observer.Pattern;

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
        /// Patterns this instance.
        /// </summary>
        private static void Pattern()
        {
            Console.WriteLine("Invoking the  Pattern...");
            Console.WriteLine("I ");

            // Configure Observer pattern
            var s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();
        }

        /// <summary>
        /// Examples this instance.
        /// </summary>
        private static void Example()
        {
            Console.WriteLine("TODO the  example...");
        }
    }
}
