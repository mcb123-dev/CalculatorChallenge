namespace CalculatorChallenge.ConsoleApp
{
    public class Calculator
    {
        public static int Add(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return 0;

            // Parse the input string
            var numbers = InputParser.Parse(input);

            // Validate the numbers (check for negatives)
            NumberValidator.Validate(numbers);

            // Filter out numbers > 1000
            numbers = NumberValidator.FilterValidNumbers(numbers);

            // Return the sum of the valid numbers
            return numbers.Sum();
        }
    }
}
