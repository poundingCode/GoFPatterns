namespace PatternsTutorial.Behavioral.Adapter.Pattern
{
    using System;

    /// <summary>
    /// Adaptee contains the alternate code base being composed into wrapper class
    /// </summary>
    internal class Adaptee
    {
        /// <summary>
        /// The replacement method.
        /// </summary>
        public void ReplacementMethod()
        {
            Console.WriteLine("I replace the legacy method");
        }
    }
}
