using CalculatorChallenge.ConsoleApp;

while (true)
{
    var input = Console.ReadLine() ?? "0";  //Added the null-coalescing operator to suppress the possible null reference warning.
    input = input.Replace("\\n", "\n"); //Removes the extra escape character created by Console.ReadLine()

    var output = Calculator.Add(input);

    Console.WriteLine(output);
}