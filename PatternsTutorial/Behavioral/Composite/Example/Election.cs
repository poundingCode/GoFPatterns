// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Election.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The election.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Behavioral.Composite.Example
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The election.
    /// </summary>
    internal class Election
    {
        /// <summary>
        /// The gop.
        /// </summary>
        private readonly PoliticalParty gop;

        /// <summary>
        /// The dnc.
        /// </summary>
        private readonly PoliticalParty dnc;

        /// <summary>
        /// Initializes a new instance of the <see cref="Election"/> class.
        /// </summary>
        public Election()
        {
            this.gop = new PoliticalParty("GOP");
            this.dnc = new PoliticalParty("DNC");
            this.RegisterCampaigns();
        }

        /// <summary>
        /// The hold primary.
        /// </summary>
        public void HoldPrimary()
        {
            this.gop.ElectCandidate();
            this.dnc.ElectCandidate();
        }

        /// <summary>
        /// The hold election.
        /// </summary>
        public void HoldElection()
        {
           var red = this.gop.GeneralElection();
           var blue = this.dnc.GeneralElection();
            this.ProjectWinner(red > blue ? this.gop : this.dnc);
        }

        /// <summary>
        /// The register campaigns.
        /// </summary>
        public void RegisterCampaigns()
        {
            this.gop.AddCampaign(new PresidentialCampaign(new Person { Name = "Marco Rubio" }) { Supporters = new List<Supporter>(5000) });
            this.gop.AddCampaign(new PresidentialCampaign(new Person { Name = "Donald Trump" }) { Supporters = new List<Supporter>(25000) });
            this.gop.AddCampaign(new PresidentialCampaign(new Person { Name = "Ted Cruz" }) { Supporters = new List<Supporter>(9000) });
            this.dnc.AddCampaign(new PresidentialCampaign(new Person { Name = "Bernie Sanders" }) { Supporters = new List<Supporter>(70000) });
            this.dnc.AddCampaign(new PresidentialCampaign(new Person { Name = "Hillary Clinton" }) { Supporters = new List<Supporter>(40000) });
        }

        /// <summary>
        /// The project winner.
        /// </summary>
        /// <param name="party">
        /// The party.
        /// </param>
        private void ProjectWinner(PoliticalParty party)
        {
            Console.WriteLine("The " + party.Name + " won. " + party.GetCampaign().Candidate.Name + " is president");
        }
    }
}
