// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class Invoke.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Behavioral.Proxy
{
    using System;

    using PatternsTutorial.Behavioral.Proxy.Example;

    /// <summary>
    /// Class Invoke.
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
        /// Patterns this instance.
        /// </summary>
        private static void Pattern()
        {
            Console.WriteLine("Invoking the Proxy Pattern...");
            Console.WriteLine("The proxy design pattern allows you to provide an interface to other objects by creating a wrapper class as the proxy. The wrapper class, which is the proxy, can add additional functionality to the object of interest without changing the object's code.");

            // Create proxy and request a service
            var proxy = new Pattern.Proxy();
            proxy.Request();
        }

        /// <summary>
        /// Examples this instance.
        /// </summary>
        private static void Example()
        {
            Console.WriteLine("Invoking the Proxy example...");
            ICar car = new ProxyCar(new Driver(16));
            car.Travel();

            car = new ProxyCar(new Driver(25));
            car.Travel();
        }
    }
}
