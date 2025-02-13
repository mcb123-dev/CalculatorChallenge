using CalculatorChallenge.ConsoleApp.App;
using System;
using System.Threading;

namespace CalculatorChallenge.ConsoleApp.UI
{
    /// Manages the application lifecycle.
    public class ConsoleApp
    {
        private readonly AppLogic _appLogic;
        private readonly CancellationTokenSource _cts;

        public ConsoleApp()
        {
            _appLogic = new AppLogic();
            _cts = new CancellationTokenSource();

            // Handle Ctrl+C to allow graceful shutdown
            Console.CancelKeyPress += HandleCancelKeyPress;
        }

        public void Run()
        {
            Console.WriteLine("Press Ctrl+C to stop the application...");
            _appLogic.Execute(_cts.Token);
        }

        private void HandleCancelKeyPress(object? sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine("Ctrl+C detected. Stopping application...");
            e.Cancel = true; // Prevent immediate termination
            _cts.Cancel();
        }
    }
}
