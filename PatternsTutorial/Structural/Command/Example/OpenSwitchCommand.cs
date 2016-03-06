namespace PatternsTutorial.Structural.Command.Example.CommandPattern
{
    public class OpenSwitchCommand : ICommand
    {
        private ISwitchable _switchable;

        public OpenSwitchCommand(ISwitchable switchable)
        {
            this._switchable = switchable;
        }

        public void Execute()
        {
            this._switchable.PowerOff();
        }
    }
}