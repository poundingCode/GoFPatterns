// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Ability.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   defines the interface for objects that can have responsibilities added to them dynamically.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Decorator.Example
{
    /// <summary>
    /// defines the interface for objects that can have responsibilities added to them dynamically.
    /// </summary>
    internal abstract class Ability
    {
        /// <summary>
        /// The _name.
        /// </summary>
        private readonly string _name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ability"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public Ability(string name)
        {
            this._name = name;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
        }

        /// <summary>
        /// Operations this instance.
        /// </summary>
        internal abstract void Physical();
    }
}
