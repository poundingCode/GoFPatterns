// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteHandler3.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The concrete handler 3.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.ChainOfResponsibility.Pattern
{
    using System;

    /// <summary>
    /// The concrete handler 3.
    /// </summary>
    internal class ConcreteHandler3 : Handler
    {
        /// <summary>
        /// The handle request.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        internal override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
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
