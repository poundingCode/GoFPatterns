// --------------------------------------------------------------------------------------------------------------------
// <copyright  file="Abstraction.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   This will be the abstract class that will have the abstract logic to be implemented. Most importantly, this will hold a reference to the bridge (that will internally have a reference to the system through which notification is to be sent).
//   The rest is just like any other interface-based definition of the functions to be implemented.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Bridge.Pattern
{
    /// <summary>
    /// This will be the abstract class that will have the abstract logic to be implemented. Most importantly, this will hold a reference to the bridge (that will internally have a reference to the system through which notification is to be sent). 
    /// The rest is just like any other interface-based definition of the functions to be implemented.
    /// </summary>
    internal class Abstraction
    {
        /// <summary>
        /// Sets the implementor.
        /// </summary>
        /// <value>The implementor.</value>
        public Implementor Implementor
        {
            set { this.implementor = value; }
        }

        /// <summary>
        /// Gets the implementor.
        /// </summary>
        /// <value>The implementor.</value>
        protected Implementor implementor { get; private set; }

        /// <summary>
        /// Operations this instance.
        /// </summary>
        public virtual void Operation()
        {
            this.implementor.Operation();
        }
    }
}
