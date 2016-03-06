// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Facade.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class Facade.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Facade.Pattern
{
    using System;

    /// <summary>
    /// Class Facade.
    /// </summary>
    internal class Facade
    {
        /// <summary>
        /// The _one
        /// </summary>
        private readonly SubSystem1 _one;

        /// <summary>
        /// The _two
        /// </summary>
        private readonly SubSystem2 _two;

        /// <summary>
        /// Initializes a new instance of the <see cref="Facade"/> class.
        /// </summary>
        internal Facade()
        {
            this._one = new SubSystem1();
            this._two = new SubSystem2();
        }

        /// <summary>
        /// Methods a
        /// </summary>
        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ---- ");
            this._one.MethodOne();
            this._two.MethodTwo();
        }

        /// <summary>
        /// Methods the b
        /// </summary>
        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---- ");
            this._two.MethodTwo();
        }
    }
}
