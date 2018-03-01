namespace OOCalculator.Commands
{
    public class Divide : CommandBase
    {
        public override string Name => "/";

        public override int Process(int a, int b)
        {
            return a / b;
        }
    }
}
