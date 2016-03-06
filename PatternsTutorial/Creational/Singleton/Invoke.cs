// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The invoke.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.Singleton
{
    using System;

    /// <summary>
    /// The invoke.
    /// </summary>
    internal static class Invoke
    {
        /// <summary>
        /// The samples.
        /// </summary>
        internal static void Samples()
        {
            Console.WriteLine("Invoking the Singleton.Pattern");
            Pattern.Singleton.DoSomethingInteresting();
            Example.Mutex.DoSomethingInteresting();
            Example.DoubleCheckedLockingUnsafe.DoSomethingInteresting();
            Example.DoubleCheckedLockingVolatile.DoSomethingInteresting();
            Example.Framework.DoSomethingInteresting();
        }
    }
}
