// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoubleCheckedLockingUnsafe.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The double checked locking unsafe.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.Singleton.Example
{
    using System;

    /// <summary>
    /// The double checked locking unsafe.
    /// </summary>
    internal class DoubleCheckedLockingUnsafe
    {
        /// <summary>
        /// The mutex.
        /// </summary>
        private static readonly object mutex = new object();

        /// <summary>
        /// The instance 
        /// </summary>
        private static DoubleCheckedLockingUnsafe instance;

        /// <summary>
        /// Gets the instance, but Double-Check locking reduces the overhead of acquiring locks, but can be unsafe in certain language/hardware combinations
        /// </summary>
        /// <value>The instance.</value>
        public static DoubleCheckedLockingUnsafe Instance
        {
            get
            {
                // double-checking 
                if (instance != null) 
                {
                    return instance;
                }

                lock (mutex)
                {
                    return instance ?? (instance = new DoubleCheckedLockingUnsafe());
                }
            }
        }

        /// <summary>
        /// The do something interesting.
        /// </summary>
        public static void DoSomethingInteresting()
        {
            Console.WriteLine("I am a singleton pattern using a double-check lock, but not safe across all language/hardware combinations");
        }
    }
}
