// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICar.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The Car interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Behavioral.Proxy.Example
{
    /// <summary>
    /// The Car interface.
    /// </summary>
    internal interface ICar
    {
        /// <summary>
        /// The travel.
        /// </summary>
        void Travel();

        /// <summary>
        /// Gets or sets the current speed.
        /// </summary>
        int CurrentSpeed { get; set; }
    }
}
