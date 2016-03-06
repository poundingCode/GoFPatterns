namespace PatternsTutorial.Behavioral.Flyweight.Example
{
    using System;

    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    internal class Rectangle : IShape
    {
        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Printing Rectangle");
        }
    }
}