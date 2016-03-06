// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PresidentialCampaign.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The presidential campaign.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Composite.Example
{
    /// <summary>
    /// The presidential campaign.
    /// </summary>
    internal class PresidentialCampaign : Campaign
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PresidentialCampaign"/> class.
        /// </summary>
        /// <param name="candidate">
        /// The candidate.
        /// </param>
        public PresidentialCampaign(Person candidate) : base(candidate)
        {
        }
    }
}
