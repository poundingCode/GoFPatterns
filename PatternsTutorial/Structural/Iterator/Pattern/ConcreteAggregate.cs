// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteAggregate.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'ConcreteAggregate' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Iterator.Pattern
{
    using System.Collections;

    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>
    internal class ConcreteAggregate : Aggregate
    {
        /// <summary>
        /// The _items
        /// </summary>
        private readonly ArrayList items = new ArrayList();

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        public int Count
        {
            get { return this.items.Count; }
        }

        /// <summary>
        /// Gets or sets the <see cref="System.Object"/> at the specified index.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <returns>
        /// System Object.
        /// </returns>
        public object this[int index]
        {
            get { return this.items[index]; }
            set { this.items.Insert(index, value); }
        }

        /// <summary>
        /// Creates the iterator.
        /// </summary>
        /// <returns>the Iterator.</returns>
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}