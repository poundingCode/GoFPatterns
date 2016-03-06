// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Framework.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The framework.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.Singleton.Example
{
    using System;

    /// <summary>
    /// The framework.
    /// </summary>
    internal class Framework
    {
        /// <summary>
        /// The framework.
        /// </summary>
        private static readonly Framework framework = new Framework();

        /// <summary>
        /// Prevents a default instance of the <see cref="Framework"/> class from being created. 
        /// The instance 
        /// </summary>
        private Framework()
        {
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static Framework Instance { get { return framework; } }

        /// <summary>
        /// The do something interesting.
        /// </summary>
        public static void DoSomethingInteresting()
        {
            Console.WriteLine("I am a singleton pattern taking advantage of an upgraded version of the framework.  Now isn't this easier?");
        }
    }
}
