// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class Invoke.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Flyweight
{
    using System;

    using PatternsTutorial.Behavioral.Flyweight.Example;
    using PatternsTutorial.Behavioral.Flyweight.Pattern;

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
            Console.WriteLine("Invoking the Adaptor Pattern...");
            Console.WriteLine("I Match interfaces of different classes");

            // Arbitrary extrinsic state
            var extrinsicstate = 22;

            var factory = new FlyweightFactory();

            // Work with different flyweight instances
            var fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            var fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            var fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            var fu = new UnsharedConcreteFlyweightclass();

            fu.Operation(--extrinsicstate);
        }

        /// <summary>
        /// The example.
        /// </summary>
        private static void Example()
        {
            Console.WriteLine("Invoking the Flyweight example...");
            var sof = new ShapeObjectFactory();

            var shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();

            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();

            var numObjs = sof.TotalObjectsCreated;
            Console.WriteLine("\nTotal No of Objects created = {0}", numObjs);
        }
    }
}
