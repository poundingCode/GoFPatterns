// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Defines the Invoke type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.TemplateMethod
{
    using System;

    using PatternsTutorial.Structural.TemplateMethod.Pattern;

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
            Console.WriteLine("Invoking the Template Method Pattern...");
            Console.WriteLine("I ");

            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();

            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();
        }

        /// <summary>
        /// The example.
        /// </summary>
        private static void Example()
        {
            Console.WriteLine("TODO the Template Method example...");
        }
    }
}
