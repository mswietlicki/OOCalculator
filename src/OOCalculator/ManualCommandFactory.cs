using System.Collections.Generic;
using System.Linq;
using OOCalculator.Commands;

namespace OOCalculator
{
    public class ManualCommandFactory : ICommandFactory
    {
        List<ICommand> _commands = new List<ICommand>();
        public ManualCommandFactory()
        {
            _commands.Add(new Add());
            _commands.Add(new Multiply())
        }
        public ICommand GetCommand(string name)
        {
            var command = _commands.FirstOrDefault(_ => _.CanProcess(name));
            if(command != null)
                return command;
            throw new KeyNotFoundException($"Command {name} not implemented!");
        }
    }
}
