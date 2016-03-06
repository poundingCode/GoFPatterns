// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.AbstractFactory
{
    using System;

    using PatternsTutorial.Creational.AbstractFactory.Example;
    using PatternsTutorial.Creational.AbstractFactory.Pattern;

    /// <summary>
    /// The program.
    /// </summary>
    public static class Invoke
    {
        /// <summary>
        /// The execute.
        /// </summary>
        public static void Samples()
        {
            Console.WriteLine("Creating an object by specifying a class explicitly commits you to a particular implementation, complicating future changes. ");
            Console.WriteLine("The AbstractFactory.Pattern creates objects indirectly...");
            var fact1 = new ConcreteFactory1();
            var client1 = new Pattern.Client(fact1);
            client1.Run();

            var fact2 = new ConcreteFactory2();
            var client2 = new Pattern.Client(fact2);
            client2.Run();

            Console.WriteLine();
            Console.WriteLine("Invoking the AbstractFactory.Example");

            LanguageFactory spanishFactory = new SpanishLanguageFactory();
            var spanish = new Creational.AbstractFactory.Example.Client(spanishFactory);

            LanguageFactory frenchFactory = new FrenchLanguageFactory();
            var french = new Creational.AbstractFactory.Example.Client(frenchFactory);

            spanish.Translate(french.ClientLanguage);
            french.Translate(spanish.ClientLanguage);
        }
    }
}
