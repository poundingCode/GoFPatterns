namespace PatternsTutorial.Behavioral.Bridge.Example
{
    using System;

    /// <summary>
    /// The two d printer.
    /// </summary>
    internal class TwoDPrinter : Printer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwoDPrinter"/> class.
        /// </summary>
        public TwoDPrinter()
        {
            Console.WriteLine("I'm a 2-D printer. I refine the abstract class Printer");
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
