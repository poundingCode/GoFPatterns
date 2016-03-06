// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChicagoStylePizzaMaker.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The chicago style pizza maker.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.FactoryMethod.Expanded
{
    using System;

    /// <summary>
    /// The chicago style pizza maker.
    /// </summary>
    public class ChicagoStylePizzaMaker : PizzaMaker
    {
        /// <summary>
        /// The hot pizza.
        /// </summary>
        private IPizza hotPizza;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ChicagoStylePizzaMaker"/> class.
        /// </summary>
        protected internal ChicagoStylePizzaMaker()
        {
            Console.WriteLine("Hello! I'm a ChicagoStylePizzaMaker and I make pizza a meal!");
            this.BakeTimeInMinutes = 20;
            this.Temperature = 450;
        }

        /// <summary>
        /// The deliver pizza.
        /// </summary>
        /// <returns>
        /// The <see cref="IPizza"/>.
        /// </returns>
        public override IPizza DeliverPizza()
        {
            Console.WriteLine("Best served with " + this.hotPizza.BestServedWith);
            Console.WriteLine("Enjoy your pizza!");
            Console.WriteLine();
            return this.hotPizza;
        }

        /// <summary>
        /// The make pizza.
        /// </summary>
        protected override void MakePizza()
        {
            Console.Write("Chicago-style!\n");
            var assembledIngredients = new ChicagoStylePizza();
            foreach (var ingredient in assembledIngredients.Ingredients)
            {
                Console.WriteLine(ingredient);
            }

            this.hotPizza = this.BakeInOven(assembledIngredients);
        }

        /// <summary>
        /// The bake in oven.
        /// </summary>
        /// <param name="pizza">
        /// The pizza.
        /// </param>
        /// <returns>
        /// The <see cref="IPizza"/>.
        /// </returns>
        private IPizza BakeInOven(IPizza pizza)
        {
            // todo: add logic to control baking duration
            Console.WriteLine("I bake at " + this.Temperature + " degrees for " + this.BakeTimeInMinutes + " minutes...");
            return pizza;
        }
    }
}