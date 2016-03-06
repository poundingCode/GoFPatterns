// -------------------------------------------------------------------------------------------------------------------- 
// <copyright file="Agility.cs" company="James Fleming">
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
    internal class Agility : Superpower
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Agility"/> class.
        /// </summary>
        public Agility() : base("Agility")
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
            Console.WriteLine("Ability to react faster than a normal human and to possess greater flexibility and with higher/farther jumping capacity.");
        }
    }
}
