// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NeapolitanStylePizzaMaker.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   overrides the factory method for creating ConcreteProduct objects of type NeapolitanStylePizza
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.FactoryMethod.Expanded
{
    using System;

    /// <summary>
    /// overrides the factory method for creating ConcreteProduct objects of type NeapolitanStylePizza
    /// </summary>
    public class NeapolitanStylePizzaMaker : PizzaMaker
    {
        /// <summary>
        /// The hot pizza.
        /// </summary>
        private IPizza hotPizza;

        /// <summary>
        /// Initializes a new instance of the <see cref="NeapolitanStylePizzaMaker"/> class.
        /// </summary>
        protected internal NeapolitanStylePizzaMaker()
        {
            Console.WriteLine("Ciao! I'm NeapolitanStylePizzaMaker and I make the best pizza!");
            this.BakeTimeInMinutes = 3;
            this.Temperature = 1100;
        }

        /// <summary>
        /// The make pizza.
        /// </summary>
        protected override void MakePizza()
        {
            Console.Write("Neapolitan-style!\n");
            var assembledIngredients = new NeapolitanStylePizza();
            foreach (var ingredient in assembledIngredients.Ingredients)
            {
                Console.WriteLine(ingredient);
            }

            this.hotPizza = this.BakeInOvenWoodFiredBrick(assembledIngredients);
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
            Console.WriteLine("Bone Appetite!");
            Console.WriteLine();
            return this.hotPizza;
        }

        /// <summary>
        /// The bake in oven wood fired brick.
        /// </summary>
        /// <param name="pizza">
        /// The pizza.
        /// </param>
        /// <returns>
        /// The <see cref="IPizza"/>.
        /// </returns>
        private IPizza BakeInOvenWoodFiredBrick(IPizza pizza)
        {
            // todo: add logic to control baking duration
            Console.WriteLine("I bake at " + this.Temperature + " degrees for " + this.BakeTimeInMinutes + " minutes...");
            return pizza;
        }
    }
}