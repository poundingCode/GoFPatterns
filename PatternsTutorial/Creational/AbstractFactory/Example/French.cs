// --------------------------------------------------------------------------------------------------------------------
// <copyright file="French.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The postal label.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.AbstractFactory.Example
{
    using System;

    /// <summary>
    /// The postal label.
    /// </summary>
    public class French : Translation
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
        public override Language Translate(Language language)
        {
            Console.WriteLine("Translation of " + language.Name + " to French");
            Console.WriteLine("Bonjour le monde");
            return new FrenchLanguageDictionary();
        }
    }
}
