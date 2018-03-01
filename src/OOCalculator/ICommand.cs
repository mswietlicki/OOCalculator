namespace OOCalculator
{
    public interface ICommand
    {
        string Name { get; }
        bool CanProcess(string command);
        int Process(int a, int b);
    }
}
