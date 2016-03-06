namespace PatternsTutorial.Behavioral.Adapter.Pattern
{
    /// <summary>
    /// Class Adaptor is a way of wrapping the legacy code.
    /// adapts the interface Adaptee to the Target interface
    /// </summary>
    internal class Adaptor : Target
    {
        /// <summary>
        /// The adaptee.
        /// </summary>
        private readonly Adaptee adaptee = new Adaptee();

        /// <summary>
        /// The method.
        /// </summary>
        public override void Method()
        {
            this.adaptee.ReplacementMethod();
        }
    }
}
