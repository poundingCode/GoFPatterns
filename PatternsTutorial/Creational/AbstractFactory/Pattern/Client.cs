// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The client.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.AbstractFactory.Pattern
{
    /// <summary>
    /// The client.
    /// </summary>
    internal class Client
    {
        /// <summary>
        /// The _abstract product a.
        /// </summary>
        private readonly AbstractProductA abstractProductA;

        /// <summary>
        /// The _abstract product b.
        /// </summary>
        private readonly AbstractProductB abstractProductB;

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="factory">
        /// The factory.
        /// </param>
        public Client(AbstractFactory factory)
        {
            this.abstractProductB = factory.CreateProductB();
            this.abstractProductA = factory.CreateProductA();
        }

        /// <summary>
        /// The run.
        /// </summary>
        public void Run()
        {
            this.abstractProductB.Interact(this.abstractProductA);
            this.abstractProductA.Interact(this.abstractProductB);
        }
    }
}
