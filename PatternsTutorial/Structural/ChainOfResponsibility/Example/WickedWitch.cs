namespace PatternsTutorial.Structural.ChainOfResponsibility.Example
{
    using System;

    internal class WickedWitch : Protagonist
    {
        public override void HandleThreat(Threat threat)
        {
            if (this.CanHandle(threat))
            {
                Console.WriteLine("{0} handled the threat of {1}", this.GetType().Name, threat.Threatlevel);
                Console.WriteLine("Unleash my flying monkeys!");
            }
            else if (successor != null)
            {
                Console.WriteLine("My flying monkeys can't handle {0}!", threat.Threatlevel);
                successor.HandleThreat(threat);
            }
        }

        public bool CanHandle(Threat threat)
        {
            return threat.Threatlevel == Threatlevel.Dorothy;
        }
    }
}
