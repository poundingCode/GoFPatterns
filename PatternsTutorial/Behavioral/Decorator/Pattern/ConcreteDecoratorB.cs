// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteDecoratorB.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class ConcreteDecoratorB.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Decorator.Pattern
{
    using System;

    /// <summary>
    /// Class ConcreteDecoratorB.
    /// </summary>
    internal class ConcreteDecoratorB : Decorator
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        internal override void Operation()
        {
            base.Operation();
            this.AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }

        /// <summary>
        /// Adds the behavior.
        /// </summary>
        internal void AddedBehavior()
        {
        }
    }
}
