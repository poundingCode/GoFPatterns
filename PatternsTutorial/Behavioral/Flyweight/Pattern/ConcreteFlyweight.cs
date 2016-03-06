// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteFlyweight.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class ConcreteFlyweight.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Flyweight.Pattern
{
    using System;

    /// <summary>
    /// Class ConcreteFlyweight.
    /// </summary>
    internal class ConcreteFlyweight : Flyweight
    {
        /// <summary>
        /// Operations the specified extrinsic state.
        /// </summary>
        /// <param name="extrinsicState">
        /// The extrinsic state.
        /// </param>
        public override void Operation(int extrinsicState)
        {
            Console.WriteLine("ConcreteFlyweight: " + extrinsicState);
        }
    }
}
