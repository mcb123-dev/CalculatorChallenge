using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
