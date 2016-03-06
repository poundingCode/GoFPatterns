// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Decorator.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   maintains a reference to a Component object and defines an interface that conforms to Component's interface
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Behavioral.Decorator.Pattern
{
    /// <summary>
    /// maintains a reference to a Component object and defines an interface that conforms to Component's interface
    /// </summary>
    internal class Decorator : Component
    {
        /// <summary>
        /// Gets the component
        /// </summary>
        protected Component Component { get; private set; }

        /// <summary>
        /// Sets the component.
        /// </summary>
        /// <param name="comp">
        /// The comp.
        /// </param>
        internal void SetComponent(Component comp)
        {
            this.Component = comp;
        }

        /// <summary>
        /// Operations this instance.
        /// </summary>
        internal override void Operation()
        {
            if (this.Component != null)
            {
                this.Component.Operation();
            }
        }
    }
}
