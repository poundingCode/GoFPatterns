// --------------------------------------------------------------------------------------------------------------------
// <copyright  file="Superpower.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   maintains a reference to a Component object and defines an interface that conforms to Component's interface
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Decorator.Example
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// maintains a reference to a Component object and defines an interface that conforms to Component's interface
    /// </summary>
    internal class Superpower : Ability
    {
        /// <summary>
        /// The mutants.
        /// </summary>
        private readonly List<Mutant> mutants;

        /// <summary>
        /// Initializes a new instance of the <see cref="Superpower"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public Superpower(string name) : base("Super-" + name)
        {
             mutants = new List<Mutant>();
        }

        /// <summary>
        /// Gets or sets the ability.
        /// </summary>
        /// <value>The ability.</value>
        protected Ability Ability { get; set; }

        /// <summary>
        /// The get mutants.
        /// </summary>
        public void GetMutants()
        {
            Console.WriteLine("Mutants with " + this.Name);
            foreach (var mutant in this.mutants)
            {
                Console.WriteLine(mutant.Name);
            }
        } 

        /// <summary>
        /// Sets the component.
        /// </summary>
        /// <param name="mutant">
        /// The comp.
        /// </param>
        internal void Empower(Mutant mutant)
        {
            Console.WriteLine("Empowering " + mutant.Name + " with " + this.Name);
            mutant.AddAbility(this);
            this.mutants.Add(mutant);
        }

        /// <summary>
        /// Operations this instance.
        /// </summary>
        internal override void Physical()
        {
            if (this.Ability != null)
            {
                this.Ability.Physical();
            }
        }
    }
}
