// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteSubject.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'ConcreteSubject' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Observer.Pattern
{
    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    internal class ConcreteSubject : Subject
    {
        /// <summary>
        /// Gets or sets the subject state.
        /// </summary>
        internal string SubjectState { get; set; }
    }
}