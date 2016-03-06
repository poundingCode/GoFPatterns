// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteImplementorA.cs" company="James Fleming">
//   poundingCode@gmail.com 
// </copyright>
// <summary>
//   The 'ConcreteImplementorA' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Behavioral.Composite.Pattern
{
    using System;

    /// <summary>
    /// The 'ConcreteImplementorA' class
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