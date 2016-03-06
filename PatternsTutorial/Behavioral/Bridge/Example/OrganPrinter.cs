namespace PatternsTutorial.Behavioral.Bridge.Example
{
    using System;

    /// <summary>
    /// The organ printer.
    /// </summary>
    internal class OrganPrinter : IBridgeMethods
    {
        /// <summary>
        /// The print.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public void Print(string message)
        {
            Console.WriteLine("I'm an organ printer");
            Console.WriteLine(message);
        }
    }
}
