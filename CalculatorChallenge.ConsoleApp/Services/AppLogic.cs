using CalculatorChallenge.ConsoleApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChallenge.ConsoleApp.App
{
    /// Contains business logic for the console application.
    public class AppLogic
    {
        public void Execute(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                var input = Console.ReadLine() ?? "0";  //Added the null-coalescing operator to suppress the possible null reference warning.
                input = input.Replace("\\n", "\n"); //Removes the extra escape character created by Console.ReadLine()

                var output = Calculator.Add(input);

                Console.WriteLine(output);
            }

            Console.WriteLine("Application is shutting down gracefully...");
        }
    }
}
