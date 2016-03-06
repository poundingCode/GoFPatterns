// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RealSubject.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class RealSubject.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Proxy.Pattern
{
    using System;

    /// <summary>
    /// Class RealSubject.
    /// </summary>
    internal class RealSubject : Subject
    {
        /// <summary>
        /// Requests this instance.
        /// </summary>
        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }
}
