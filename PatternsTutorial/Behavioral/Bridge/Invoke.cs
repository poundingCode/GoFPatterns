// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Decouple an abstraction from its implementation so that the two can vary independently.
//   the Bridge Pattern's purpose is to provide multiple pathways between two components that are nothing but achieving many-to-many communication between multiple implementations of the source and the target components.
//   So technically, it receives a request from one of the many implementations of the source component, and based on the client requirements, sends it to one of the many implementations of the target component.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Bridge
{
    using System;

    using PatternsTutorial.Behavioral.Bridge.Example;
    using PatternsTutorial.Behavioral.Bridge.Pattern;

    using Abstraction = PatternsTutorial.Behavioral.Bridge.Pattern.Abstraction;
    using RefinedAbstraction = PatternsTutorial.Behavioral.Bridge.Pattern.RefinedAbstraction;

    /// <summary>
    /// Decouple an abstraction from its implementation so that the two can vary independently.
    /// the Bridge Pattern's purpose is to provide multiple pathways between two components that are nothing but achieving many-to-many communication between multiple implementations of the source and the target components. 
    /// So technically, it receives a request from one of the many implementations of the source component, and based on the client requirements, sends it to one of the many implementations of the target component.
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
            Console.WriteLine("Invoking the Bridge Pattern...");
            Console.WriteLine("I Separates an object’s interface from its implementation");
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
            var dd = new TwoDPrinter { IBridgeDevices = new LaserPrinter() };
            dd.Print("Printing a my manifesto");

            var ddd = new ThreeDPrinter { IBridgeDevices = new OrganPrinter() };
            ddd.Print("Printing a new ear");
        }
    }
}
