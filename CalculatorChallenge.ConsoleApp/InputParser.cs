using System.Text.RegularExpressions;

namespace CalculatorChallenge.ConsoleApp
{
    public class InputParser
    {
        /// <summary>
        /// Parses comma, newline, single custom delimiter (ex. //{delimiter}\n{numbers}),
        /// or long custom delimiter (ex. //[{delimiter}]\n{numbers}) separated numbers from a string input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>List of integers</returns>
        public static List<int> Parse(string input)
        {
            var delimiters = new List<string> { ",", "\n" }; // Default delimiters

            var match = Regex.Match(input, @"^//(.)\n(.*)|^//\[(.*?)\]\n(.*)");
            if (match.Success)
            {
                var delimiter = string.Empty;
                if (match.Groups[1].Success) //single delimiter
                {
                    delimiter = match.Groups[1].Value;
                    input = match.Groups[2].Value;
                }
                else if (match.Groups[3].Success) //long delimiter
                {
                    delimiter = match.Groups[3].Value;
                    input = match.Groups[4].Value;
                }

                delimiters.Add(delimiter);
            }

            // Split the numbers using the delimiters
            var numbers = input.Split(delimiters.ToArray(), StringSplitOptions.None);

            return numbers.Select(n => int.TryParse(n, out var value) ? value : 0).ToList();
        }

    }
}
