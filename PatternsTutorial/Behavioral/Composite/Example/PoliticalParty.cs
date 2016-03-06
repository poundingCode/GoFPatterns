// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PoliticalParty.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The political party.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Behavioral.Composite.Example
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The political party.
    /// </summary>
    internal class PoliticalParty
    {
        /// <summary>
        /// The _name.
        /// </summary>
        private readonly string _name;

        /// <summary>
        /// The _campaigns.
        /// </summary>
        private readonly List<Campaign> _campaigns;

        /// <summary>
        /// The winner.
        /// </summary>
        private Campaign winner;

        /// <summary>
        /// Initializes a new instance of the <see cref="PoliticalParty"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public PoliticalParty(string name)
        {
            this._name = name;
            this._campaigns = new List<Campaign>();
        }

        /// <summary>
        /// Gets the campaigns.
        /// </summary>
        public List<Campaign> Campaigns
        {
            get
            {
                return this._campaigns;
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
        }

        /// <summary>
        /// The get campaign.
        /// </summary>
        /// <returns>
        /// The <see cref="Campaign"/>.
        /// </returns>
        public Campaign GetCampaign()
        {
            return this.winner;
        }

        /// <summary>
        /// The elect candidate.
        /// </summary>
        public void ElectCandidate()
        {
            this.winner = this._campaigns.FirstOrDefault(x => x.Supporters.Capacity == this._campaigns.Max(tally => tally.Supporters.Capacity));
        }

        /// <summary>
        /// The general election.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int GeneralElection()
        {
            var votes = 0;
            foreach (var campaign in this._campaigns)
            {
                if (campaign.Candidate == this.winner.Candidate)
                {
                    votes += campaign.Supporters.Capacity;
                }
                else
                {
                    votes += (int)(campaign.Supporters.Capacity * .7);
                }
            }

            return votes;
        }

        /// <summary>
        /// The add campaign.
        /// </summary>
        /// <param name="campaign">
        /// The campaign.
        /// </param>
        public void AddCampaign(Campaign campaign)
        {
            this._campaigns.Add(campaign);
        }
    }
}
