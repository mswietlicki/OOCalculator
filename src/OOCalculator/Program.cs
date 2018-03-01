using System;
using System.Text.RegularExpressions;

namespace OOCalculator
{
    class Program
    {
        static Regex commandPattern = new Regex(@"^(\d+) ?(\D) ?(\d+)$");
        static void Main(string[] args)
        {
            ShowWelcomeMessage();

            var calculator = new Calculator(new ManualCommandFactory());
            string commandStr;
            while ((commandStr = Console.ReadLine()) != "q")
                ProcessCommand(commandStr, calculator);
        }

        private static void ProcessCommand(string commandStr, Calculator calculator)
        {
            try
            {
                var result = calculator.Calculate(commandStr);
                Console.WriteLine($"= {result}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }

        private static void ShowWelcomeMessage()
        {
            Console.WriteLine("#OOCalculator");
            Console.WriteLine();
            Console.WriteLine("Write commands in a form [number][operator][number] e.g. 3+4.");
            Console.WriteLine();
        }
    }
}
