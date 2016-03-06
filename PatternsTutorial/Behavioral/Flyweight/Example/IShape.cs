// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IShape.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The 'Flyweight' interface
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Flyweight.Example
{
    using System;

    /// <summary>
    /// The 'Flyweight' interface
    /// </summary>
    internal interface IShape
    {
        /// <summary>
        /// Prints this instance.
        /// </summary>
        void Print();
    }

    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    internal class Circle : IShape
    {
        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Printing Circle");
        }
    }
}
