// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteHandler1.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The concrete handler 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.ChainOfResponsibility.Pattern
{
    using System;

    /// <summary>
    /// The concrete handler 1.
    /// </summary>
    internal class ConcreteHandler1 : Handler
    {
        /// <summary>
        /// The handle request.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        internal override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
            Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            }
            else if (successor != null)
            {
            successor.HandleRequest(request);
            }
        }
    }
}
