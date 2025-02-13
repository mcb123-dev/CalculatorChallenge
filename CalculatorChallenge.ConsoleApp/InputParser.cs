using System.Text.RegularExpressions;

namespace CalculatorChallenge.ConsoleApp
{
    public class InputParser
    {
        /// <summary>
        /// Parses comma, newline, or single custom delimiter (ex. //{delimiter}\n{numbers}) separated numbers from a string input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>List of integers</returns>
        public static List<int> Parse(string input)
        {
            var delimiters = new List<string> { ",", "\n" }; // Default delimiters

            // Check if input has a custom delimiter
            var match = Regex.Match(input, @"^//(.)\n(.*)", RegexOptions.Singleline);
            if (match.Success)
            {
                // Custom delimiter provided
                var delimiter = match.Groups[1].Value;
                input = match.Groups[2].Value;
                delimiters.Add(delimiter);
            }

            // Split the numbers using the delimiters
            var numbers = input.Split(delimiters.ToArray(), StringSplitOptions.None);

            return numbers.Select(n => int.TryParse(n, out var value) ? value : 0).ToList();
        }
    }
}
