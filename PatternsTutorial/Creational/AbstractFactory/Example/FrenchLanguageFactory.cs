// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FrenchLanguageFactory.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The delicate purchase factory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.AbstractFactory.Example
{
    /// <summary>
    /// The delicate purchase factory.
    /// </summary>
    public class FrenchLanguageFactory : LanguageFactory
    {
        /// <summary>
        /// The create packaging.
        /// </summary>
        /// <returns>
        /// The <see cref="Language"/>.
        /// </returns>
        public override Language CreateLanguage()
        {
            return new FrenchLanguageDictionary();
        }

        /// <summary>
        /// The create delivery document.
        /// </summary>
        /// <returns>
        /// The <see cref="Translation"/>.
        /// </returns>
        public override Translation CreateTranslation()
        {
            return new French();
        }
    }
}
