// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteIterator.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'ConcreteIterator' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Iterator.Pattern
{
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    internal class ConcreteIterator : Iterator
    {
        /// <summary>
        /// The _aggregate.
        /// </summary>
        private readonly ConcreteAggregate _aggregate;

        /// <summary>
        /// The _current.
        /// </summary>
        private int _current = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteIterator"/> class.
        /// </summary>
        /// <param name="aggregate">
        /// The aggregate.
        /// </param>
        internal ConcreteIterator(ConcreteAggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        /// <summary>
        /// Firsts this instance.
        /// </summary>
        /// <returns>System.Object.</returns>
        internal override object First()
        {
            return this._aggregate[0];
        }

        /// <summary>
        /// Nexts this instance.
        /// </summary>
        /// <returns>System.Object.</returns>
        internal override object Next()
        {
            object ret = null;
            if (this._current < this._aggregate.Count - 1)
            {
                ret = this._aggregate[++this._current];
            }

            return ret;
        }

        /// <summary>
        /// The current item.
        /// </summary>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        internal override object CurrentItem()
        {
            return this._aggregate[this._current];
        }

        /// <summary>
        /// The is done.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        internal override bool IsDone()
        {
            return this._current >= this._aggregate.Count;
        }
    }
}