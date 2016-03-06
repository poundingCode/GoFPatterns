// --------------------------------------------------------------------------------------------------------------------
// <copyright file="User.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Class SubSystem1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Facade.Example
{
    using System;

    /// <summary>
    /// Class SubSystem1.
    /// </summary>
    internal class User
    {
        /// <summary>
        /// The validate.
        /// </summary>
        /// <param name="userName">
        /// The user name.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        public void Validate(string userName, string password)
        {
            Console.WriteLine("Validate user credentials...");
        }
    }
}