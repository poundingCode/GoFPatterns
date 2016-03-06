// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteImplementorA.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The concrete implementor a.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Behavioral.Bridge.Pattern
{
    using System;

    /// <summary>
    /// The concrete implementor a.
    /// </summary>
    internal class ConcreteImplementorA : Implementor
    {
        /// <summary>
        /// The operation.
        /// </summary>
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }
}
