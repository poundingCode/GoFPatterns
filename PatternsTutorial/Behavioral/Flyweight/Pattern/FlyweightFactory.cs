// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlyweightFactory.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class FlyweightFactory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Flyweight.Pattern
{
    using System.Collections;

    /// <summary>
    /// Class FlyweightFactory.
    /// </summary>
    internal class FlyweightFactory
    {
        /// <summary>
        /// The flyweights
        /// </summary>
        private readonly Hashtable flyweights = new Hashtable();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlyweightFactory"/> class.
        /// </summary>
        public FlyweightFactory()
        {
            this.flyweights.Add("X", new ConcreteFlyweight());
            this.flyweights.Add("Y", new ConcreteFlyweight());
            this.flyweights.Add("Z", new ConcreteFlyweight());
        }

        /// <summary>
        /// Gets the flyweight.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <returns>
        /// Fly weight.
        /// </returns>
        public Flyweight GetFlyweight(string key)
        {
            return (Flyweight)this.flyweights[key];
        }
    }
}
