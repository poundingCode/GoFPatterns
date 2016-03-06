// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NonterminalExpression.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class NonterminalExpression.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Interpreter.Pattern
{
    using System;

    /// <summary>
    /// Class NonterminalExpression.
    /// </summary>
    internal class NonterminalExpression : AbstractExpression
    {
        /// <summary>
        /// Interprets the specified context.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        internal override void Interpret(Context context)
        {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }
}
