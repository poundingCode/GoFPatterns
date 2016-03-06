// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteImplementorB.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'ConcreteImplementorB' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Composite.Pattern
{
    using System;

    /// <summary>
    /// The 'ConcreteImplementorB' class
    /// </summary>
    internal class ConcreteImplementorB : Implementor
    {
        /// <summary>
        /// The operation.
        /// </summary>
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}