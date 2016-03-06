﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TerminalExpression.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class TerminalExpression.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Interpreter.Pattern
{
    using System;

    /// <summary>
    /// Class TerminalExpression.
    /// </summary>
    internal class TerminalExpression : AbstractExpression
    {
        /// <summary>
        /// Interprets the specified context.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        internal override void Interpret(Context context)
        {
            Console.WriteLine("Called Terminal.Interpret()");
        }
    }
}
