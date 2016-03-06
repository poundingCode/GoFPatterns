namespace PatternsTutorial.Behavioral.Adapter.Pattern
{
    using System;

    /// <summary>
    /// Class Target. collaborates with objects conforming to the Target interface
    /// </summary>
    internal class Target
    {
        /// <summary>
        /// Methods this instance.
        /// </summary>
        public virtual void Method()
        {
            Console.WriteLine("I am a legacy method");
        }
    }
}
