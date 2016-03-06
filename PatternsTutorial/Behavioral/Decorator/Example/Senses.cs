// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Senses.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class ConcreteDecoratorB.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Decorator.Example
{
    using System;

    /// <summary>
    /// Class ConcreteDecoratorB.
    /// </summary>
    internal class Senses : Superpower
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Senses"/> class.
        /// </summary>
        public Senses() : base("Senses")
        {
        }

        /// <summary>
        /// Operations this instance.
        /// </summary>
        internal override void Physical()
        {
            base.Physical();
            this.AddedBehavior();
        }

        /// <summary>
        /// Adds the behavior.
        /// </summary>
        internal void AddedBehavior()
        {
            Console.WriteLine("I can pass through walls...");
        }
    }
}
