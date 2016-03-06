// --------------------------------------------------------------------------------------------------------------------
// <copyright company="James Fleming" file="Invoke.cs">
//   James Fleming
// </copyright>
// <summary>
//   The Adaptor pattern is a versatile pattern that joins together types that were not designed to work with each other. It
//   is one of those patterns that comes in useful when dealing with legacy code
//   You can use the facade pattern when you need to provide a simple interface as an entry point to access a complex system.
//   In essence, if you have a complex system where the abstractions and the implementations of it are tightly coupled and you would not want the consumer to contact the complex system directly,
//   the facade pattern is an excellent choice.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Adapter
{
    using System;

    using PatternsTutorial.Behavioral.Adapter.Example;
    using PatternsTutorial.Behavioral.Adapter.Pattern;

    /// <summary>
    ///  The Adaptor pattern is a versatile pattern that joins together types that were not designed to work with each other. It 
    ///  is one of those patterns that comes in useful when dealing with legacy code
    ///  You can use the facade pattern when you need to provide a simple interface as an entry point to access a complex system. 
    ///  In essence, if you have a complex system where the abstractions and the implementations of it are tightly coupled and you would not want the consumer to contact the complex system directly, 
    ///  the facade pattern is an excellent choice.
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
            Console.WriteLine("Invoking the Adaptor Pattern...");
            Console.WriteLine("I match interfaces of different classes that weren't designed to work together");
            var legacyClass = new Target();
            legacyClass.Method();

            var replacementClass = new Adaptor();
            replacementClass.Method();

            Target target = new Adaptor();
            target.Method();
        }

        /// <summary>
        /// Examples this instance.
        /// </summary>
        private static void Example()
        {
            Console.WriteLine("Invoking the Adaptor example...");
            ITargetEmployeeSource target = new EmployeeAdapter();

            var client = new ThirdPartyBillingSystem(target);
            client.ShowEmployeeList();
        }
    }
}
