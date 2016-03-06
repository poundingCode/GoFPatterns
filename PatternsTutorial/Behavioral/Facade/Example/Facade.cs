// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Facade.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class Facade.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Facade.Example
{
    /// <summary>
    /// Class Facade.
    /// </summary>
    internal class FacadeExample
    {
        /// <summary>
        /// The user
        /// </summary>
        private readonly User user = new User();

        /// <summary>
        /// The card
        /// </summary>
        private readonly CreditCard card = new CreditCard();

        /// <summary>
        /// Operation1s the specified user name.
        /// </summary>
        /// <param name="userName">
        /// Name of the user.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        public void VerifyUser(string userName, string password)
        {
            this.user.Validate(userName, password);
        }

        /// <summary>
        /// Operation2s the specified card number.
        /// </summary>
        /// <param name="cardNumber">
        /// The card number.
        /// </param>
        /// <param name="amount">
        /// The amount.
        /// </param>
        public void ChargeCard(string cardNumber, double amount)
        {
            this.card.Validate("1234567890");
            this.card.PayAmount(cardNumber, amount);
        }
    }
}
