namespace CalculatorChallenge.ConsoleApp
{
    // Class responsible for validating numbers
    public class NumberValidator
    {
        /// <summary>
        /// Validates the numbers (check for negatives)
        /// </summary>
        /// <param name="numbers"></param>
        /// <exception cref="ArgumentException">Throw when the input string contains any negative numbers.</exception>
        public static void Validate(List<int> numbers)
        {
            var negatives = numbers.Where(n => n < 0).ToList();
            if (negatives.Any())
            {
                throw new ArgumentException($"Negative numbers not allowed: {string.Join(",", negatives)}");
            }
        }

        /// <summary>
        /// Removes numbers greater than 1000
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>List of integers</returns>
        public static List<int> FilterValidNumbers(List<int> numbers)
        {
            return numbers.Where(n => n <= 1000).ToList();
        }
    }
}
