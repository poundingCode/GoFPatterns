// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AbstractClass.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class AbstractClass.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Structural.TemplateMethod.Pattern
{
    /// <summary>
    /// Class AbstractClass.
    /// </summary>
    internal abstract class AbstractClass
    {
        /// <summary>
        /// Primitives the operation1.
        /// </summary>
        public abstract void PrimitiveOperation1();

        /// <summary>
        /// Primitives the operation2.
        /// </summary>
        public abstract void PrimitiveOperation2();
 
        /// <summary>
        /// Templates the method.
        /// </summary>
        internal void TemplateMethod()
        {
            this.PrimitiveOperation1();
            this.PrimitiveOperation2();
        }
    }
}
