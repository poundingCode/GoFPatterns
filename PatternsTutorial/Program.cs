// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class Program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial
{
    /// <summary>
    /// Class Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">
        /// The arguments.
        /// </param>
        public static void Main(string[] args)
        {
            // Behavioral
            Behavioral.Invoker.Invoke();

            // Creation patterns
            Creational.Invoker.Invoke();

            Structural.Invoker.Invoke();
        }
    }
}
