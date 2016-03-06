// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class Invoke.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Interpreter
{
    using System;
    using System.Collections;

    using PatternsTutorial.Structural.Interpreter.Pattern;

    /// <summary>
    /// Class Invoke.
    /// </summary>
    internal static class Invoke
    {
        /// <summary>
        /// The execute.
        /// </summary>
        internal static void Samples()
        {
            Pattern();
            Example();
        }

        /// <summary>
        /// Patterns this instance.
        /// </summary>
        private static void Pattern()
        {
            Console.WriteLine("Invoking the Interpreter Pattern...");
            Console.WriteLine("I ");
            var context = new Context();

            // Usually a tree 
            var list = new ArrayList();

            // Populate 'abstract syntax tree' 
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            // Interpret
            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }
        }

        /// <summary>
        /// Examples this instance.
        /// </summary>
        private static void Example()
        {
            Console.WriteLine("TODO the Interpreter example...");
        }
    }
}
