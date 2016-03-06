// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Durability.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class ConcreteDecoratorA.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Decorator.Example
{
    using System;
    
    /// <summary>
    /// Class ConcreteDecoratorA.
    /// </summary>
    internal class Durability : Superpower
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Durability"/> class.
        /// </summary>
        public Durability() : base("Durability")
        {
        }

        /// <summary>
        /// Operations this instance.
        /// </summary>
        internal override void Physical()
        {
            base.Physical();
            Console.WriteLine("Higher resistance to one or more forms of damage");
        }
    }
}
