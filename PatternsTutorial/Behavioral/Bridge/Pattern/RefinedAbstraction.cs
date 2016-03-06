// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RefinedAbstraction.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class RefinedAbstraction.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Bridge.Pattern
{
    /// <summary>
    /// Class RefinedAbstraction.
    /// </summary>
    internal class RefinedAbstraction : Abstraction
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public override void Operation()
        {
          implementor.Operation();
        }
    }
}
