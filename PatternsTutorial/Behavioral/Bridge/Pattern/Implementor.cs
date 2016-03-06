// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Implementor.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   defines the interface for implementation classes.
//   This interface doesn't have to correspond exactly to Abstraction's interface; in fact the two interfaces can be quite different. Typically the Implementation interface provides only primitive operations, and Abstraction defines higher-level operations based on these primitives
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Bridge.Pattern
{
    /// <summary>
    /// defines the interface for implementation classes. 
    /// This interface doesn't have to correspond exactly to Abstraction's interface; in fact the two interfaces can be quite different. Typically the Implementation interface provides only primitive operations, and Abstraction defines higher-level operations based on these primitives
    /// </summary>
    internal abstract class Implementor
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public abstract void Operation();
    }
}
