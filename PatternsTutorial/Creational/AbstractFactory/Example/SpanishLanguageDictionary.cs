// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpanishLanguageDictionary.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The standard packaging.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.AbstractFactory.Example
{
    /// <summary>
    /// The standard packaging.
    /// </summary>
    public class SpanishLanguageDictionary : Language
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        public override string Name
        {
            get
            {
                return "Spanish";
            }
        }
    }
}
