using System;

namespace OOCalculator
{
    public abstract class CommandBase : ICommand
    {
        public abstract string Name { get; }
        public virtual bool CanProcess(string command) => Name != null && Name.Equals(command, StringComparison.InvariantCultureIgnoreCase);
        public abstract int Process(int a, int b);
    }
}
