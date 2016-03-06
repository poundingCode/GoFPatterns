// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteClassA.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   A 'ConcreteClass' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.TemplateMethod.Pattern
{
    using System;

    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    internal class ConcreteClassA : AbstractClass
    {
        /// <summary>
        /// The primitive operation 1.
        /// </summary>
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
        }

        /// <summary>
        /// The primitive operation 2.
        /// </summary>
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
        }
    }
}