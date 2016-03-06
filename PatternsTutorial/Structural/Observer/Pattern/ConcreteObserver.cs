// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteObserver.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'ConcreteObserver' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Observer.Pattern
{
    using System;

    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    internal class ConcreteObserver : Observer
    {
        /// <summary>
        /// The name.
        /// </summary>
        private readonly string name;

        /// <summary>
        /// The _observer state.
        /// </summary>
        private string _observerState;

        /// <summary>
        /// The _subject.
        /// </summary>
        private ConcreteSubject _subject;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteObserver"/> class.
        /// </summary>
        /// <param name="subject">
        /// The subject.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        internal ConcreteObserver(ConcreteSubject subject, string name)
        {
            this._subject = subject;
            this.name = name;
        }
         
        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        internal ConcreteSubject Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        /// <summary>
        /// The update.
        /// </summary>
        internal override void Update()
        {
            this._observerState = this._subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}", this.name, this._observerState);
        }
    }
}