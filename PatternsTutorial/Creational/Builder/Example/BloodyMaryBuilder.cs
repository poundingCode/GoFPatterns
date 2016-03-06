// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BloodyMaryBuilder.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The bloody mary builder.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.Builder.Example
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The bloody mary builder.
    /// </summary>
    internal class BloodyMaryBuilder : CocktailBuilder
    {
        /// <summary>
        /// The cocktail.
        /// </summary>
        private readonly Cocktail cocktail = new Cocktail { Garnishes = new List<Ingredient>(), Mixers = new List<Ingredient>(), Spices = new List<Ingredient>(), Spirits = new List<Ingredient>() };

        /// <summary>
        /// Gets the name.
        /// </summary>
        public override string Name
        {
            get { return "Bloody Mary"; }
        }

        /// <summary>
        /// The get glass.
        /// </summary>
        public override void GetGlass()
        {
            this.cocktail.Glass = "Highball Glass";
        }

        /// <summary>
        /// The add ice.
        /// </summary>
        public override void AddIce()
        {
            this.cocktail.Ice = true;
        }

        /// <summary>
        /// The add spirits.
        /// </summary>
        public override void AddSpirits()
        {
            this.cocktail.Spirits.Add(new Ingredient { Name = "Vodka", Measurement = "Oz.", Quantity = 1.5 });
        }

        /// <summary>
        /// The add mixers.
        /// </summary>
        public override void AddMixers()
        {
            this.cocktail.Mixers.Add(new Ingredient { Name = "V8", Measurement = "Oz.", Quantity = 3 });
        }

        /// <summary>
        /// The add spices.
        /// </summary>
        public override void AddSpices()
        {
            this.cocktail.Spices.Add(new Ingredient { Name = "Hot sauce", Measurement = "dashes", Quantity = 4 });
            this.cocktail.Spices.Add(new Ingredient { Name = "Horseradish", Measurement = "teaspoon", Quantity = 1 });
            this.cocktail.Spices.Add(new Ingredient { Name = "Worcestershire sauce", Measurement = "dashes", Quantity = 3 });
            this.cocktail.Spices.Add(new Ingredient { Name = "Pepper", Measurement = "dashes", Quantity = 3 });
        }

        /// <summary>
        /// The add garnishes.
        /// </summary>
        public override void AddGarnishes()
        {
            this.cocktail.Garnishes.Add(new Ingredient { Name = "Lemon peel", Measurement = "twist", Quantity = 1 });
            this.cocktail.Garnishes.Add(new Ingredient { Name = "Celery", Measurement = "stalk", Quantity = 1 });
        }

        /// <summary>
        /// The mix drink.
        /// </summary>
        public override void MixDrink()
        {
            Console.WriteLine(this.cocktail.Glass);
            Console.WriteLine(this.cocktail.Ice ? "Add ice!" : "Neat!");

            foreach (var ingredient in this.cocktail.Spirits)
            {
                Console.WriteLine(ingredient.Quantity + " " + ingredient.Measurement + " of " + ingredient.Name);
            }

            foreach (var ingredient in this.cocktail.Mixers)
            {
                Console.WriteLine(ingredient.Quantity + " " + ingredient.Measurement + " of " + ingredient.Name);
            }

            foreach (var ingredient in this.cocktail.Spices)
            {
                Console.WriteLine(ingredient.Quantity + " " + ingredient.Measurement + " of " + ingredient.Name);
            }
        }
    }
}
