// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Component.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   defines the interface for objects that can have responsibilities added to them dynamically.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Decorator.Pattern
{
    /// <summary>
    /// defines the interface for objects that can have responsibilities added to them dynamically.
    /// </summary>
    internal abstract class Component
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        internal abstract void Operation();
    }
}
