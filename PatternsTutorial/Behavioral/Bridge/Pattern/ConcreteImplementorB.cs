// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteImplementorB.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class ConcreteImplementorB.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Behavioral.Bridge.Pattern
{
    using System;

    /// <summary>
    /// Class ConcreteImplementorB.
    /// </summary>
    internal class ConcreteImplementorB : Implementor
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}
