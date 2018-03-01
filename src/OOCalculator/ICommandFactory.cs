using System.Linq;

namespace OOCalculator
{
    public interface ICommandFactory {
        ICommand GetCommand(string name);
    }
}
