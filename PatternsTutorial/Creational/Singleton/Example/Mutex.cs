// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mutex.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The mutex.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.Singleton.Example
{
    using System;

    /// <summary>
    /// The mutex.
    /// </summary>
    internal class Mutex
    {
        /// <summary>
        /// The instance.
        /// </summary>
        private static Mutex instance;

        /// <summary>
        /// The mutex.
        /// </summary>
        private static readonly object mutex = new object();

        /// <summary>
        /// Prevents a default instance of the <see cref="Mutex"/> class from being created.
        /// </summary>
        private Mutex()
        {
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static Mutex Instance
        {
            get
            {
                lock (mutex)
                {
                    return instance ?? (instance = new Mutex());
                }
            }
        }

        /// <summary>
        /// The do something interesting.
        /// </summary>
        public static void DoSomethingInteresting()
        {
            Console.WriteLine("I am a singleton pattern using a lock");
        }
    }
}
