// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteDecoratorA.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class ConcreteDecoratorA.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Decorator.Pattern
{
    using System;

    /// <summary>
    /// Class ConcreteDecoratorA.
    /// </summary>
    internal class ConcreteDecoratorA : Decorator
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        internal override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }
}
