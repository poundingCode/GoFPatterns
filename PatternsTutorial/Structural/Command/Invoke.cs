// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Invoke.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests,
//   and support undoable operations.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Structural.Command
{
    using System;

    using PatternsTutorial.Structural.Command.Example.CommandPattern;
    using PatternsTutorial.Structural.Command.Pattern;

    /// <summary>
    /// Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, 
    /// and support undoable operations.
    /// </summary>
    public static class Invoke
    {
        /// <summary>
        /// The execute.
        /// </summary>
        public static void Samples()
        {
            Pattern();
            Example();
        }

        /// <summary>
        /// Patterns this instance.
        /// </summary>
        private static void Pattern()
        {
            Console.WriteLine("Invoking the Command Pattern...");
            Console.WriteLine("I ");

            // Create receiver, command, and invoker
            var receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            var invoker = new Invoker();

            // Set and execute command
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }

        /// <summary>
        /// Examples this instance.
        /// </summary>
        private static void Example()
        {
            Console.WriteLine("the Command example...");

            var toggle = DateTime.Now.Second % 2 == 0;

            ISwitchable lamp = new Light();

            // Pass reference to the lamp instance to each command
            ICommand switchClose = new CloseSwitchCommand(lamp);
            ICommand switchOpen = new OpenSwitchCommand(lamp);

            // Pass reference to instances of the Command objects to the switch
            var @switch = new Switch(switchClose, switchOpen);

            if (toggle)
            {
                @switch.Close();
            }
            else 
            {
                @switch.Open();
            }
        }
    }
}
