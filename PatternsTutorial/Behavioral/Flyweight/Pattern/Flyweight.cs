// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Flyweight.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class Flyweight.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Flyweight.Pattern
{
    /// <summary>
    /// Class Flyweight.
    /// </summary>
    internal abstract class Flyweight
    {
        /// <summary>
        /// Operations the specified extrinsic state.
        /// </summary>
        /// <param name="extrinsicstate">
        /// The extrinsic state.
        /// </param>
        public abstract void Operation(int extrinsicstate);
    }
}
