using System.Text.RegularExpressions;

namespace CalculatorChallenge.ConsoleApp.Core
{
    public class InputParser
    {
        /// <summary>
        /// Parses comma, newline, single custom delimiter (ex. //{delimiter}\n{numbers}),
        /// or multiple long custom delimiter(s) (ex. //[delimiter1][delimiter2]...\n{numbers}) separated numbers from a string input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>List of integers</returns>
        public static List<int> Parse(string input)
        {
            var delimiters = new List<string> { ",", "\n" }; // Default delimiters

            var match = Regex.Match(input, @"^//(.)\n(.*)|^//\[(.*?)\]\n(.*)");
            if (match.Success)
            {
                if (match.Groups[1].Success) //single delimiter
                {
                    delimiters.Add(match.Groups[1].Value);
                    input = match.Groups[2].Value;
                }
                else if (match.Groups[3].Success) //long delimiters
                {
                    var matches = Regex.Matches(input, @"\[(.*?)\]");
                    foreach (Match longDelimiterMatch in matches)
                    {
                        if (longDelimiterMatch.Groups[1].Success)
                            delimiters.Add(longDelimiterMatch.Groups[1].Value);
                    }

                    input = match.Groups[4].Value;
                }
            }

            // Split the numbers using the delimiters
            var numbers = input.Split(delimiters.ToArray(), StringSplitOptions.None);

            return numbers.Select(number => int.TryParse(number, out var value) ? value : 0).ToList();
        }
    }
}