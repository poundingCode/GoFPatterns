namespace PatternsTutorial.Structural.ChainOfResponsibility.Example
{
    using System;

    internal class King : Protagonist
    {
        public override void HandleThreat(Threat threat)
        {
            if (this.CanHandle(threat))
            {
                Console.WriteLine("{0} handled the threat of {1}", this.GetType().Name, threat.Threatlevel);
                Console.WriteLine("Cry havoc and let slip the hounds of war!");
            }
            else if (successor != null)
            {
                Console.WriteLine("My hounds of war can't handle {0}!", threat.Threatlevel);
                successor.HandleThreat(threat);
            }
        }

        public bool CanHandle(Threat threat)
        {
            return threat.Threatlevel == Threatlevel.Mercenaries;
        }
    }
}
