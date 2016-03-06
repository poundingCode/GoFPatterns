// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreditCard.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class SubSystem2.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Facade.Example
{
    using System;

    /// <summary>
    /// Class SubSystem2.
    /// </summary>
    internal class CreditCard
    {
        /// <summary>
        /// Methods the two.
        /// </summary>
        /// <param name="cardNumber">
        /// The card number.
        /// </param>
        public void Validate(string cardNumber)
        {
            Console.WriteLine("Validate credit card...");
        }

        /// <summary>
        /// Pays the amount.
        /// </summary>
        /// <param name="cardNumber">
        /// The card number.
        /// </param>
        /// <param name="amount">
        /// The amount.
        /// </param>
        public void PayAmount(string cardNumber, double amount)
        {
            Console.WriteLine("Pay amount...");
        }
    }
}
