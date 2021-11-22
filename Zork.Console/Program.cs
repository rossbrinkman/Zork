namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFileName = "Zork.json";
            string gameFileName = (args.Length > 0 ? args[(int)CommandLineArguments.RoomsFileName] : defaultGameFileName);
            Game game = Game.LoadFromFile(gameFileName);

            ConsoleOutputService output = new ConsoleOutputService();
            ConsoleInputService input = new ConsoleInputService();

            output.WriteLine("Welcome to Zork!");
            game.Start(output, input);
            Game.Look(game);

            while (game.IsRunning)
            {
                output.Write("\n> ");
                input.ProcessInput();
            }

            game.Output.WriteLine("Thank you for playing!");
        }

        private enum CommandLineArguments
        {
            RoomsFileName = 0
        }
    }
}
