using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OOCalculator
{
    public class Calculator
    {
        Regex _commandPattern = new Regex(@"^(\d+) ?(\D) ?(\d+)$");
        private readonly ICommandFactory _commandFactory;
        public Calculator(ICommandFactory commandFactory)
        {
            _commandFactory = commandFactory;
        }

        public int Calculate(string expression) {
            var command = _commandPattern.Match(expression);
            if (command.Success)
                return Calculate(int.Parse(command.Groups[1].Value), int.Parse(command.Groups[3].Value), command.Groups[2].Value);
            throw new ArgumentException("Incorrect command format!");
        }
        public int Calculate(int a, int b, string commandName)
        {
            var command = _commandFactory.GetCommand(commandName);
            return command.Process(a, b);
        }
    }
}
