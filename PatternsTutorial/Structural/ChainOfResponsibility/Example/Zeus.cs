namespace PatternsTutorial.Structural.ChainOfResponsibility.Example
{
    using System;

    internal class Zeus : Protagonist
    {
        public override void HandleThreat(Threat threat)
        {
            if (this.CanHandle(threat))
            {
                Console.WriteLine("{0} handled the threat of {1}", this.GetType().Name, threat.Threatlevel);
                Console.WriteLine("Release the Kracken!");
            }
            else if (successor != null)
            {
                successor.HandleThreat(threat);
            }
        }

        public bool CanHandle(Threat threat)
        {
            return threat.Threatlevel == Threatlevel.Titans;
        }
    }
}
