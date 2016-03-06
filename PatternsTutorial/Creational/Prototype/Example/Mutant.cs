// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mutant.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The mutant.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.Prototype.Example
{
    using System.Collections.Generic;

    /// <summary>
    /// The mutant.
    /// </summary>
    internal class Mutant : IMutant
    {
        /// <summary>
        /// The name.
        /// </summary>
        private readonly string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Mutant"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        internal Mutant(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        /// <summary>
        /// Gets or sets the character.
        /// </summary>
        public string Character { get; set; }

        /// <summary>
        /// Gets or sets the mutation.
        /// </summary>
        public Mutation Mutation { get; set; }

        /// <summary>
        /// The shallow copy.
        /// </summary>
        /// <returns>
        /// The <see cref="IMutant"/>.
        /// </returns>
        public IMutant ShallowCopy()
        {
            return (IMutant)MemberwiseClone();
        }

        /// <summary>
        /// The deep copy.
        /// </summary>
        /// <returns>
        /// The <see cref="IMutant"/>.
        /// </returns>
        public IMutant DeepCopy()
        {
            var mutant = (IMutant)MemberwiseClone();
            mutant.Mutation = new Mutation { Name = string.Copy(this.Mutation.Name), Powers = new List<string>(this.Mutation.Powers.Count) };
            mutant.Mutation.Powers.AddRange(this.Mutation.Powers);
            return mutant;
        }
    }
}
