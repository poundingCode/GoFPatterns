// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AbstractExpression.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class AbstractExpression.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Structural.Interpreter.Pattern
{
    /// <summary>
    /// Class AbstractExpression.
    /// </summary>
    internal abstract class AbstractExpression
    {
        /// <summary>
        /// Interprets the specified context.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        internal abstract void Interpret(Context context);
    }
}
