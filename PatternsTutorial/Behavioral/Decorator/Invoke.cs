// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The invoke.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Decorator
{
    using System;

    using PatternsTutorial.Behavioral.Decorator.Example;
    using PatternsTutorial.Behavioral.Decorator.Pattern;

    /// <summary>
    /// The invoke.
    /// </summary>
    public static class Invoke
    {
        /// <summary>
        /// The execute.
        /// </summary>
        public static void Samples()
        {
            Pattern();
            Example(); 
        }

        /// <summary>
        /// The pattern.
        /// </summary>
        private static void Pattern()
        {
            Console.WriteLine("Invoking the Adaptor Pattern...");
            Console.WriteLine("I Match interfaces of different classes");

            // Create ConcreteComponent and two Decorators
            var c = new ConcreteComponent();
            var d1 = new ConcreteDecoratorA();
            var d2 = new ConcreteDecoratorB();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();
        }

        /// <summary>
        /// The example.
        /// </summary>
        private static void Example()
        {
            Console.WriteLine("Invoking the Adaptor example...");
            var sabreTooth = new Mutant("Sabretooth");
            var beast = new Mutant("Beast");
            var durability = new Durability();
            var agility = new Agility();
            var senses = new Senses();

            // Link decorators
            agility.Empower(beast);
            agility.Empower(sabreTooth);
            durability.Empower(sabreTooth);
            senses.Empower(sabreTooth);
            sabreTooth.Physical();
            agility.GetMutants();
        }
    }
}
