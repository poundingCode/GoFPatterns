// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteHandle2.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The concrete handler 2.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.ChainOfResponsibility.Pattern
{
    using System;

    /// <summary>
    /// The concrete handler 2.
    /// </summary>
    internal class ConcreteHandler2 : Handler
    {
        /// <summary>
        /// The handle request.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        internal override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
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
