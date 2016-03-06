// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnsharedConcreteFlyweight.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class UnsharedConcreteFlyweightclass.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Flyweight.Pattern
{
    using System;

    /// <summary>
    /// Class UnsharedConcreteFlyweightclass.
    /// </summary>
    internal class UnsharedConcreteFlyweightclass : Flyweight
    {
        /// <summary>
        /// Operations the specified extrinsicstate.
        /// </summary>
        /// <param name="extrinsicstate">
        /// The extrinsicstate.
        /// </param>
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("UnsharedConcreteFlyweight: " +
            extrinsicstate);
        }
    }
}
