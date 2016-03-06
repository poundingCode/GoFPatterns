namespace PatternsTutorial.Behavioral.Bridge.Example
{
    using System;

    /// <summary>
    /// The printer.
    /// </summary>
    internal abstract class Printer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Printer"/> class.
        /// </summary>
        protected Printer()
        {
            Console.WriteLine("I'm printer the abstract class to refine.");
        }

        /// <summary>
        /// Gets or sets the i bridge devices.
        /// </summary>
        /// <value>The i bridge devices.</value>
        public IBridgeMethods IBridgeDevices { get; set; }

        /// <summary>
        /// The print.
        /// </summary>
        /// <param name="msg">
        /// The msg.
        /// </param>
        public abstract void Print(string msg);
    }
}
