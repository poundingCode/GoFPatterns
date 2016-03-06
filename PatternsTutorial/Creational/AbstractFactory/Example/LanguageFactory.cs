// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LanguageFactory.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The purchase factory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.AbstractFactory.Example
{
    /// <summary>
    /// The purchase factory.
    /// </summary>
    public abstract class LanguageFactory
    {
        /// <summary>
        /// The create packaging.
        /// </summary>
        /// <returns>
        /// The <see cref="Language"/>.
        /// </returns>
        public abstract Language CreateLanguage();

        /// <summary>
        /// The create delivery document.
        /// </summary>
        /// <returns>
        /// The <see cref="Translation"/>.
        /// </returns>
        public abstract Translation CreateTranslation();
    }
}
