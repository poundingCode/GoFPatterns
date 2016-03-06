// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpanishLanguageFactory.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The standard purchase factory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.AbstractFactory.Example
{
    /// <summary>
    /// The standard purchase factory.
    /// </summary>
    public class SpanishLanguageFactory : LanguageFactory
    {
        /// <summary>
        /// The create packaging.
        /// </summary>
        /// <returns>
        /// The <see cref="Language"/>.
        /// </returns>
        public override Language CreateLanguage()
        {
            return new SpanishLanguageDictionary();
        }

        /// <summary>
        /// The create delivery document.
        /// </summary>
        /// <returns>
        /// The <see cref="Translation"/>.
        /// </returns>
        public override Translation CreateTranslation()
        {
            return new Spanish();
        }
    }
}
