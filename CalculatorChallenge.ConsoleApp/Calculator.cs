namespace CalculatorChallenge.ConsoleApp
{
    public class Calculator
    {
        public static int Add(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return 0;

            // Parse the input string
            var numbers = InputParser.Parse(input);

            // Return the sum of the valid numbers
            return numbers.Sum();
        }
    }
}
