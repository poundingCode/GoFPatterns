// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RefinedAbstraction.cs" >
//   
// </copyright>
// <summary>
//   The 'RefinedAbstraction' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Composite.Pattern
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    internal class RefinedAbstraction : Abstraction
    {
        /// <summary>
        /// The operation.
        /// </summary>
        public override void Operation()
        {
            this.implementor.Operation();
        }
    }
}