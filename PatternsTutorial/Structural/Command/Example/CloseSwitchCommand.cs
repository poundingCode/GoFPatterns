namespace PatternsTutorial.Structural.Command.Example.CommandPattern
{
    public class CloseSwitchCommand : ICommand
    {
        private ISwitchable _switchable;

        public CloseSwitchCommand(ISwitchable switchable)
        {
            this._switchable = switchable;
        }

        public void Execute()
        {
            this._switchable.PowerOn();
        }
    }
}