using Newtonsoft.Json;
using System;
using System.IO;
using System.ComponentModel;
using Zork.Common;
using System.Collections.Generic;
using System.Linq;

namespace Zork
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<bool> IsRunningChanged;

        public World World { get; set; }

        [JsonIgnore]
        public Player Player { get; set; }

        [JsonIgnore]
        public bool IsRunning {
            get
            {
                return _isRunning;
            }
            set
            {
                if (_isRunning != value)
                {
                    _isRunning = value;
                    IsRunningChanged?.Invoke(this, _isRunning);
                }
            }
        }

        public IOutputService Output { get; set; }
        public IInputService Input { get; set; }

        [JsonIgnore]
        public Dictionary<string, Commands> CommandsDictionary { get; private set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;

            CommandsDictionary = new Dictionary<string, Commands>()
            {
                { "QUIT", new Commands("QUIT", new string[] { "QUIT", "Q", "BYE" }, Quit) },
                { "LOOK", new Commands("LOOK", new string[] { "LOOK", "L" }, Look) },
                { "NORTH", new Commands("NORTH", new string[] { "NORTH", "N" }, game => Move(game, Directions.North)) },
                { "SOUTH", new Commands("SOUTH", new string[] { "SOUTH", "S" }, game => Move(game, Directions.South)) },
                { "EAST", new Commands("EAST", new string[] { "EAST", "E"}, game => Move(game, Directions.East)) },
                { "WEST", new Commands("WEST", new string[] { "WEST", "W" }, game => Move(game, Directions.West)) },
                { "REWARD", new Commands("REWARD", new string[] { "REWARD", "R" }, Reward) },
                { "SCORE", new Commands("SCORE", new string[] { "SCORE", "SC" }, Score) },
            };
        }

        public void Start(IOutputService output, IInputService input)
        {
            Assert.IsTrue(input != null);
            Input = input;

            Input.InputReceived += Input_InputReceivedHandler;

            Assert.IsTrue(output != null);
            Output = output;

            IsRunning = true;
            previousRoom = null;
        }

        private void Input_InputReceivedHandler(object sender, string commandString)
        {
            commandString = commandString.ToUpper();
            Commands foundCommand = null;
            foreach (Commands command in CommandsDictionary.Values)
            {
                if (command.Verbs.Contains(commandString))
                {
                    foundCommand = command;
                    break;
                }
            }

            if (foundCommand != null)
            {
                foundCommand.Action(this);
                Player.moves++;
            }
            else
            {
                Output.WriteLine("Unknown command.");
                Output.WriteLine(Player.Location);
            }
        }

        private static void Move(Game game, Directions direction)
        {
            if (game.Player.Move(direction) == false)
            {
                game.Output.WriteLine("The way is shut!");
                game.Output.WriteLine(game.Player.Location);
            }
            else
            {
                Game.Look(game);
            }
        }

        public static void Look(Game game)
        {
            game.Output.WriteLine(game.Player.Location);
            game.Output.WriteLine(game.Player.Location.Description);
        }

        private static void Quit(Game game) => game.IsRunning = false;

        private static void Reward(Game game)
        {
            game.Player.score++;
            game.Output.WriteLine(game.Player.Location);
        }

        private static void Score(Game game)
        {
            game.Output.WriteLine($"Your score would be {game.Player.score} in {game.Player.moves} move(s)");
            game.Output.WriteLine(game.Player.Location);
        }

        public static Game LoadFromFile(string gameFileName) => Load(File.ReadAllText(gameFileName));

        public static Game Load(string jsonString)
        {
            Game game = JsonConvert.DeserializeObject<Game>(jsonString);
            game.Player = game.World.SpawnPlayer();
            return game;
        }

        public void OutputLocationAndLook()
        {
            Output.WriteLine(Player.Location);
            if (previousRoom != Player.Location)
            {
                Game.Look(this);
                previousRoom = Player.Location;
            }
        }

        private Room previousRoom;
        private bool _isRunning;
    }
}
