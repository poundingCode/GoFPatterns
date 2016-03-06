// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Defines the Invoke type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Visitor
{
    using System;

    using PatternsTutorial.Structural.Visitor.Pattern;

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
            Console.WriteLine("Invoking the Visitor Pattern...");
            Console.WriteLine("I ");

            var o = new ObjectStructure();
            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());

            // Create visitor objects
            var v1 = new ConcreteVisitor1();
            var v2 = new ConcreteVisitor2();

            // Structure accepting visitors
            o.Accept(v1);
            o.Accept(v2);
        }

        /// <summary>
        /// The example.
        /// </summary>
        private static void Example()
        {
            Console.WriteLine("TODO the Visitor example...");
        }
    }
}
