// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Subject.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class Subject.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Observer.Pattern
{
    using System.Collections.Generic;

    /// <summary>
    /// Class Subject.
    /// </summary>
    internal abstract class Subject
    {
        /// <summary>
        /// The observers
        /// </summary>
        private readonly List<Observer> observers = new List<Observer>();

        /// <summary>
        /// Attaches the specified observer.
        /// </summary>
        /// <param name="observer">
        /// The observer.
        /// </param>
        internal void Attach(Observer observer)
        {
            this.observers.Add(observer);
        }

        /// <summary>
        /// Detaches the specified observer.
        /// </summary>
        /// <param name="observer">
        /// The observer.
        /// </param>
        internal void Detach(Observer observer)
        {
            this.observers.Remove(observer);
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        internal void Notify()
        {
            foreach (var o in this.observers)
            {
                o.Update();
            }
        }
    }
}
