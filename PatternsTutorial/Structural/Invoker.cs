// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoker.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural
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
            Console.WriteLine("Invoking the Behavioral patterns...");

            ChainOfResponsibility.Invoker.Invoke();
            Command.Invoke.Samples();
        }
    }
}
