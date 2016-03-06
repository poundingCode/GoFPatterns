// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Campaign.cs" company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The campaign.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Behavioral.Composite.Example
{
    using System.Collections.Generic;

    /// <summary>
    /// The campaign.
    /// </summary>
    internal abstract class Campaign
    {
        /// <summary>
        /// The _candidate.
        /// </summary>
        private readonly Person candidate;

        /// <summary>
        /// Initializes a new instance of the <see cref="Campaign"/> class.
        /// </summary>
        /// <param name="candidate">
        /// The candidate.
        /// </param>
        public Campaign(Person candidate)
        {
            this.candidate = candidate;
        }

        /// <summary>
        /// Gets the candidate.
        /// </summary>
        public Person Candidate 
        { 
            get
            {
                return this.candidate;
            } 
        }

        /// <summary>
        /// Gets or sets the supporters.
        /// </summary>
        public List<Supporter> Supporters { get; set; }
    }
}
