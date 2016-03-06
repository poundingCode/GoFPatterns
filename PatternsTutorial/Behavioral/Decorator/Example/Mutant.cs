// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mutant.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   defines an object to which additional responsibilities can be attached
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Behavioral.Decorator.Example
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// defines an object to which additional responsibilities can be attached
    /// </summary>
    internal class Mutant : Ability
    {
        /// <summary>
        /// The abilities.
        /// </summary>
        private readonly List<Ability> abilities;

        /// <summary>
        /// Initializes a new instance of the <see cref="Mutant"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public Mutant(string name) : base(name)
        {
            this.abilities = new List<Ability>();
        }

        /// <summary>
        /// The add ability.
        /// </summary>
        /// <param name="ability">
        /// The ability.
        /// </param>
        internal void AddAbility(Ability ability)
        {
            this.abilities.Add(ability);
        }

        /// <summary>
        /// Operations this instance.
        /// </summary>
        internal override void Physical()
        {
            Console.WriteLine("My superpowers are:");

            foreach (var ability in this.abilities)
            {
                Console.WriteLine(ability.Name);
            }
        }
    }
}
