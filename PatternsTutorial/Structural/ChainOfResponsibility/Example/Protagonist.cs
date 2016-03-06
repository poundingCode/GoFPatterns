using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTutorial.Structural.ChainOfResponsibility.Example
{
    internal abstract class Protagonist
    {
        protected Protagonist successor;

        public void SetSuccessor(Protagonist successor)
        {
            this.successor = successor;
        }

        public abstract void HandleThreat(Threat threat);
    }
}
