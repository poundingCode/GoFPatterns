// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Handler.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The handler.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.ChainOfResponsibility.Pattern
{
    /// <summary>
    /// The handler.
    /// </summary>
    internal abstract class Handler
    {
        /// <summary>
        /// The successor.
        /// </summary>
        protected Handler successor;

        /// <summary>
        /// The set successor.
        /// </summary>
        /// <param name="successor">
        /// The successor.
        /// </param>
        internal void SetSuccessor(Handler successor)
        {
          this.successor = successor;
        }

        /// <summary>
        /// The handle request.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        internal abstract void HandleRequest(int request);
   }
}
