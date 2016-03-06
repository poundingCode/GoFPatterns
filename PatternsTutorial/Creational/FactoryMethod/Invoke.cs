// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class Invoker.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.FactoryMethod
{
    using System;

    using PatternsTutorial.Creational.FactoryMethod.Example;
    using PatternsTutorial.Creational.FactoryMethod.Expanded;
    using PatternsTutorial.Creational.FactoryMethod.Pattern;

    /// <summary>
    /// Class Invoker.
    /// </summary>
    public static class Invoke
    {
        /// <summary>
        /// Invokes this instance.
        /// </summary>
        public static void Samples()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Creating an object by specifying a class explicitly commits you to a particular implementation, complicating future changes. ");
            Console.WriteLine("The FactoryMethod.Pattern creates objects indirectly...");
            var factoryMethod = new ConcreteCreator();
            factoryMethod.CreateOperation();

            Console.WriteLine("\n");
            Console.WriteLine("Invoking the FactoryMethod.Example");

            var pizzaShop = new PizzaShop();
            pizzaShop.PizzaMaker();

            Console.WriteLine("\n");
            Console.WriteLine("Invoking the FactoryMethod.Example II");

            var neapolitanPizzeria = new NeapolitanStylePizzaMaker();
            neapolitanPizzeria.PlaceOrder();
            neapolitanPizzeria.DeliverPizza();

            var chicagoPizzeria = new ChicagoStylePizzaMaker();
            chicagoPizzeria.PlaceOrder();
            chicagoPizzeria.DeliverPizza();
        }
    }
}
