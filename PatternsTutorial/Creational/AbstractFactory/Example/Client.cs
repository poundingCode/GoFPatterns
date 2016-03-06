// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The client.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.AbstractFactory.Example
{
    /// <summary>
    /// The client.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// The _packaging.
        /// </summary>
        private readonly Language language;

        /// <summary>
        /// The _delivery document.
        /// </summary>
        private readonly Translation translation;

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="factory">
        /// The factory.
        /// </param>
        public Client(LanguageFactory factory)
        {
            this.language = factory.CreateLanguage();
            this.translation = factory.CreateTranslation();
        }

        /// <summary>
        /// Gets the client packaging.
        /// </summary>
        public Language ClientLanguage
        {
            get { return this.language; }
        }

        /// <summary>
        /// Gets the client document.
        /// </summary>
        public Translation ClientTranslation
        {
            get { return this.translation; }
        }

        /// <summary>
        /// Translates the specified language.
        /// </summary>
        /// <param name="languageToTranslate">
        /// The language.
        /// </param>
        /// <returns>
        /// The Language.
        /// </returns>
        public Language Translate(Language languageToTranslate)
        {
            return this.translation.Translate(languageToTranslate);
        }
    }
}
