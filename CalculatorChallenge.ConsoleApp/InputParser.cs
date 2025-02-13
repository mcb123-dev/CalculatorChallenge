namespace CalculatorChallenge.ConsoleApp
{
    public class InputParser
    {
        /// <summary>
        /// Parses comma-separated numbers from a string input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>List of integers</returns>
        public static List<int> Parse(string input)
        {
            var numbers = input.Split(',');

            return numbers.Select(n => int.TryParse(n, out var value) ? value : 0).ToList();
        }
    }
}
