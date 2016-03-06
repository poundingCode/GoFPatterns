// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Translation.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The delivery document.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.AbstractFactory.Example
{
    /// <summary>
    /// The delivery document.
    /// </summary>
    public abstract class Translation
    {
        /// <summary>
        /// The translate.
        /// </summary>
        /// <param name="language">
        /// The language.
        /// </param>
        /// <returns>
        /// The <see cref="Language"/>.
        /// </returns>
        public abstract Language Translate(Language language);
    }
}
