// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Spanish.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The courier manifest.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Creational.AbstractFactory.Example
{
    using System;

    /// <summary>
    /// The courier manifest.
    /// </summary>
    public class Spanish : Translation
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
            Console.WriteLine("Translation of " + language.Name + " to Spanish");

            Console.WriteLine("Hola Mundo");
            return new SpanishLanguageDictionary();
        }
    }
}
