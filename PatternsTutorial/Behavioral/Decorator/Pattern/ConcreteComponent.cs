// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteComponent.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   defines an object to which additional responsibilities can be attached
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Decorator.Pattern
{
    using System;

    /// <summary>
    /// defines an object to which additional responsibilities can be attached
    /// </summary>
    internal class ConcreteComponent : Component
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        internal override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}
