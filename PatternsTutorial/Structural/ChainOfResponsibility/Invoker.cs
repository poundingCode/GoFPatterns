// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.
//   Chain the receiving objects and pass the request along the chain until an object handles it.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.ChainOfResponsibility
{
    using System;
    using System.Collections.Generic;

    using PatternsTutorial.Structural.ChainOfResponsibility.Example;
    using PatternsTutorial.Structural.ChainOfResponsibility.Pattern;

    using Handler = PatternsTutorial.Structural.ChainOfResponsibility.Pattern.Handler;

    /// <summary>
    /// Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. 
    /// Chain the receiving objects and pass the request along the chain until an object handles it.
      /// </summary>
    public static class Invoker
    {
        /// <summary>
        /// Sample this instance.
        /// </summary>
        public static void Invoke()
        {
            Pattern();
            Example();
        }

        /// <summary>
        /// Patterns this instance.
        /// </summary>
        private static void Pattern()
        {
            Console.WriteLine("I avoid dependence on a specific operation, making it easier to change the way a request gets satisfied.");
            Console.WriteLine("Invoking the Chain of Responsibility Pattern...");

            // Setup Chain of Responsibility
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            // Generate and process request
            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (var request in requests)
            {
                h1.HandleRequest(request);
            }
        }

        /// <summary>
        /// Examples this instance.
        /// </summary>
        private static void Example()
        {
            Console.WriteLine("TODO the Chain of Responsibility example...");
            Protagonist elphaba = new WickedWitch();
            Protagonist henryTheEighth = new King();
            Protagonist zeus = new Zeus();
            elphaba.SetSuccessor(henryTheEighth);
            henryTheEighth.SetSuccessor(zeus);

            var threats = new List<Threat>
                              {
                                  new Threat { Threatlevel = Threatlevel.Mercenaries },
                                  new Threat { Threatlevel = Threatlevel.Dorothy },
                                  new Threat { Threatlevel = Threatlevel.Titans },
                              };

            threats.ForEach(o => elphaba.HandleThreat(o));
        }
    }
}
