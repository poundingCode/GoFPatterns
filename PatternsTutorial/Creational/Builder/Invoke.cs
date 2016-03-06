// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The invoke.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.Builder
{
    using System;

    using PatternsTutorial.Creational.Builder.Example;
    using PatternsTutorial.Creational.Builder.Pattern;

    /// <summary>
    /// The invoke.
    /// </summary>
    internal static class Invoke
    {
        /// <summary>
        /// The samples.
        /// </summary>
        internal static void Samples()
        {
            Console.WriteLine("Invoking the Builder.Pattern");
            var director = new Director();
            Builder b1 = new ConcreteBuilder();
            director.Construct(b1);
            var p1 = b1.GetResult();
            p1.Show();

            Console.WriteLine("\n");
            Console.WriteLine("Invoking the Builder.Example");
            var bartender = new Bartender();
            CocktailBuilder bloodyMaria = new BloodyMariaBuilder();
            bartender.MakeCocktail(bloodyMaria);
            Console.WriteLine("\n");

            CocktailBuilder classic = new BloodyMaryBuilder();
            bartender.MakeCocktail(classic);
        }
    }
}
