// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoker.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    public static class Invoker
    {
        /// <summary>
        /// The execute.
        /// </summary>
        public static void Invoke()
        {
            // Creation patterns
            Console.WriteLine("Invoking the Creation patterns...");

            FactoryMethod.Invoke.Samples();
            AbstractFactory.Invoke.Samples();
            Builder.Invoke.Samples();
            Singleton.Invoke.Samples();
            Prototype.Invoke.Samples();
        }
    }
}
