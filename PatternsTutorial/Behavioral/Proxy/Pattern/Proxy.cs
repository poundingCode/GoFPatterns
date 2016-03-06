// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Proxy.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class Proxy.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Proxy.Pattern
{
    /// <summary>
    /// Class Proxy.
    /// </summary>
    internal class Proxy : Subject
    {
        /// <summary>
        /// The _real subject
        /// </summary>
        private RealSubject _realSubject;

        /// <summary>
        /// Requests this instance.
        /// </summary>
        public override void Request()
        {
          // Use 'lazy initialization'
          if (_realSubject == null)
          {
              this._realSubject = new RealSubject();
          }

          this._realSubject.Request();
        }
    }
}
