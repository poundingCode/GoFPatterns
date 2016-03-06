// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoubleCheckedLockingVolatile.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The double checked locking volatile.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.Singleton.Example
{
    using System;

    /// <summary>
    /// The double checked locking volatile.
    /// </summary>
    internal class DoubleCheckedLockingVolatile
    {
        /// <summary>
        /// The mutex.
        /// </summary>
        private static readonly object mutex = new object();

        /// <summary>
        /// The instance,
        /// By updating our instance variable with the volatile keyword, we signal the field can be updated by the operating system, the hardware, or a concurrently executing thread. 
        /// Volatile insures that when our instance gets created, changes made within that constructor are not made available until the all of those changes have been completed. So now as long as you can remember to lock, double check the lock and signal for the compiler to manage volatility, you’re all set! But better still might be to let the framework manage this for me. 
        /// </summary>
        private static volatile DoubleCheckedLockingVolatile instance;

        /// <summary>
        /// Gets the instance, but Double-Check locking reduces the overhead of acquiring locks, but can be unsafe in certain language/hardware combinations
        /// </summary>
        /// <value>The instance.</value>
        public static DoubleCheckedLockingVolatile Instance
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
                    return instance ?? (instance = new DoubleCheckedLockingVolatile());
                }
            }
        }

        /// <summary>
        /// The do something interesting.
        /// </summary>
        public static void DoSomethingInteresting()
        {
            Console.WriteLine("I am a singleton pattern using a double-check lock, made safe across language/hardware combinations by using the volatile keyword. Perhaps the keyword should be 'non-volatile?");
        }
    }
}
