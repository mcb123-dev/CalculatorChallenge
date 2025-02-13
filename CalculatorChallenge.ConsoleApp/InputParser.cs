namespace CalculatorChallenge.ConsoleApp
{
    public class InputParser
    {
        /// <summary>
        /// Parses up to two comma-separated numbers from a string input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>List of integers</returns>
        /// <exception cref="ArgumentException">Thrown if more than two numbers are provided.</exception>
        public static List<int> Parse(string input)
        {
            var numbers = input.Split(',');

            if (numbers.Length > 2) throw new ArgumentException("Only up to two numbers are allowed");

            return numbers.Select(n => int.TryParse(n, out var value) ? value : 0).ToList();
        }
    }
}
