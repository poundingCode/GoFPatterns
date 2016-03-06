namespace PatternsTutorial.Behavioral.Bridge.Example
{
    using System;

    /// <summary>
    /// The three d printer.
    /// </summary>
    internal class ThreeDPrinter : Printer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDPrinter"/> class.
        /// </summary>
        public ThreeDPrinter()
        {
            Console.WriteLine("I'm an 3-D printer. I refine the abstract class Printer");
        }

        /// <summary>
        /// The print.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public override void Print(string message)
        {
            this.IBridgeDevices.Print(message);
        }
    }
}
