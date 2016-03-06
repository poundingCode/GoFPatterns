// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Receiver.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class Receiver.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Command.Pattern
{
    using System;

    /// <summary>
    /// Class Receiver.
    /// </summary>
    internal class Receiver
    {
        /// <summary>
        /// Actions this instance.
        /// </summary>
        internal void Action()
        {
            Console.WriteLine("Called Receiver.Action()");
        }
    }
}
