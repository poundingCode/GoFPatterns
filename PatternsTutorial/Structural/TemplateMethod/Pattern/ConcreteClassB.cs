// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteClassB.cs"  company="James Fleming">
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
    internal class ConcreteClassB : AbstractClass
    {
        /// <summary>
        /// The primitive operation 1.
        /// </summary>
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
        }

        /// <summary>
        /// The primitive operation 2.
        /// </summary>
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
        }
    }
}