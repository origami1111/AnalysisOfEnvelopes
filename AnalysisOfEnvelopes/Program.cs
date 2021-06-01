using System;

namespace AnalysisOfEnvelopes
{
    class Program
    {
        // TEST DATA
        // 1 10 2 4 - false | false 
        // 1 3 4 5 - true   | true
        // 4 5 1 3 - true   | true
        // 1 5 2 4 - false  | false
        // 4 6 7 5 - true   | true
        // 5 7 4 6 - true   | true

        static void Main(string[] args)
        {
            ConsoleController consoleController = new ConsoleController(args);
            consoleController.Start();

            Console.WriteLine("Программа завершена");
            Console.ReadLine();
        }

    }
}
