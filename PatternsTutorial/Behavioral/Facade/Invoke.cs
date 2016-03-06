// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class Invoke.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Facade
{
    using System;

    using PatternsTutorial.Behavioral.Facade.Example;
    using PatternsTutorial.Behavioral.Facade.Pattern;

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
            Console.WriteLine("Invoking the Facade Pattern...");
            Console.WriteLine("I provide a simplified interface to a set of sub systems and reduce the dependencies and complexities in your designs");
            var facade = new Facade();

            facade.MethodA();
            facade.MethodB();
        }

        /// <summary>
        /// Examples this instance.
        /// </summary>
        private static void Example()
        {
            Console.WriteLine("Invoking the Facade example...");
            var facade = new FacadeExample();
            facade.VerifyUser("SomeUser", "myUnbreakablePassword");
            facade.ChargeCard("1234567890", 100.00);
        }
    }
}
