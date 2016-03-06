// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The invoke.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.Prototype
{
    using System;
    using System.Collections.Generic;

    using PatternsTutorial.Creational.Prototype.Example;
    using PatternsTutorial.Creational.Prototype.Pattern;

    /// <summary>
    /// The invoke.
    /// </summary>
    public static class Invoke
    {
       /// <summary>
       /// Invokes this instance.
       /// </summary>
       public static void Samples()
       {
           Console.WriteLine();
           Console.WriteLine("Creating an object by specifying a class explicitly commits you to a particular implementation, complicating future changes. ");
           Console.WriteLine("The Prototype.Pattern creates objects indirectly...");
           Console.WriteLine();
           var p1 = new ConcretePrototypeA("A 1");
           var c1 = (ConcretePrototypeA)p1.Clone();
           Console.WriteLine("Cloned: {0}", c1.Id);

           var p2 = new ConcretePrototypeB("A 2");
           var c2 = (ConcretePrototypeB)p2.Clone();
           Console.WriteLine("Cloned: {0}", c2.Id);
           Console.WriteLine();

           var magnito = GetMagnito();

           foreach (var power in magnito.Mutation.Powers)
           {
               Console.WriteLine(power);
           }

           Console.WriteLine();
           Console.WriteLine("We Clone the mutant: " + magnito.Character);
           var clone = magnito.ShallowCopy();
           clone.Character = "Magnito - clone";

           Console.WriteLine("Clone Character: " + clone.Character);
           Console.WriteLine("Clone Mutation: " + clone.Mutation.Name);
           GroundOut(magnito);
          
           Console.WriteLine("But our clone was weakened too!");
           Console.WriteLine("Clone Mutation: " + clone.Mutation.Name);

           foreach (var power in clone.Mutation.Powers)
           {
               Console.WriteLine(power);
           }

           Console.WriteLine("Let's make a deep copy");
           
           magnito = GetMagnito();
           var deepClone = magnito.DeepCopy();
           GroundOut(magnito);

           Console.WriteLine("But our clone retains its powers!");

           Console.WriteLine("Clone Mutation: " + clone.Mutation.Name);
           foreach (var power in deepClone.Mutation.Powers)
           {
               Console.WriteLine(power);
           }
       }

        /// <summary>
        /// The ground out.
        /// </summary>
        /// <param name="magnito">
        /// The magnito.
        /// </param>
        private static void GroundOut(Mutant magnito)
        {
            Console.WriteLine("We weaken the mutant Magnito!");

            magnito.Mutation.Name = "Grounded out";
            magnito.Mutation.Powers.RemoveAll(s => s.Contains("electr"));

            Console.WriteLine("Name: " + magnito.Mutation.Name);
        }

        /// <summary>
        /// The get magnito.
        /// </summary>
        /// <returns>
        /// The <see cref="Mutant"/>.
        /// </returns>
        private static Mutant GetMagnito()
        {
            var magnito = new Mutant("Max 'Magnus' Eisenhardt")
            {
                Character = "Magnito", 
                Mutation = new Mutation
                {
                    Name = "Manipulates Magnetic Fields", 
                    Powers = new List<string>
                        {
                            "flight", 
                            "electrical force fields", 
                            "electrical bolts", 
                            "electromagnetic radiation."
                        }
                }
            };

            Console.WriteLine("Name: " + magnito.Name);
            Console.WriteLine("Character: " + magnito.Character);
            Console.WriteLine("Mutation: " + magnito.Mutation.Name);

            return magnito;
        }
    }
}
