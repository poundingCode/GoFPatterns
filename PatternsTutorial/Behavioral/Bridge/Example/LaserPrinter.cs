namespace PatternsTutorial.Behavioral.Bridge.Example
{
    using System;

    /// <summary>
    /// The laser printer.
    /// </summary>
    internal class LaserPrinter : IBridgeMethods
    {
        /// <summary>
        /// The print.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public void Print(string message)
        {
            Console.WriteLine("I'm a laser printer");
            Console.WriteLine(message);
        }
    }
}
