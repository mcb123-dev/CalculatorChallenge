using CalculatorChallenge.ConsoleApp;

while (true)
{
    var input = Console.ReadLine() ?? "0";  //Added the null-coalescing operator to suppress the possible null reference warning.

    var output = Calculator.Add(input);

    Console.WriteLine(output);
}