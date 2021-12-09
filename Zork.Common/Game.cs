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
        public event EventHandler<bool> IsResettingChanged;

        #region Properties
        public World World { get; set; }

        public List<string> Quips { get; set; } 

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

        [JsonIgnore]
        public bool IsResetting
        {
            get
            {
                return _isResetting;
            }
            set
            {
                if (_isResetting != value)
                {
                    _isResetting = value;
                    IsResettingChanged?.Invoke(this, _isResetting);
                }
            }
        }

        public IOutputService Output { get; set; }
        public IInputService Input { get; set; }

        [JsonIgnore]
        public Dictionary<string, Commands> CommandsDictionary { get; private set; }
        #endregion

        #region Game Constructor
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
                { "TAKE", new Commands("TAKE", new string[] {"TAKE", "T", "PICK UP"}, game => Take(game, _commandWords))},
                { "DROP", new Commands("DROP", new string[] { "DROP", "D"}, game => Drop(game, _commandWords))},
                { "PUT", new Commands("PUT", new string[] { "PUT", "P"}, game => Put(game, _commandWords))},
                { "INVENTORY", new Commands("INVENTORY", new string[] { "INVENTORY", "I"}, Inventory)},
                { "OPEN", new Commands("OPEN", new string[] { "OPEN", "O"}, game => Open(game, _commandWords))},
                { "CLOSE", new Commands("CLOSE", new string[] { "CLOSE", "C"}, game => Close(game, _commandWords))},
            };
        }
        #endregion

        #region Starting and Loading
        public void Start(IOutputService output, IInputService input)
        {
            Assert.IsTrue(input != null);
            Input = input;

            Input.InputReceived += Input_InputReceivedHandler;

            Assert.IsTrue(output != null);
            Output = output;

            IsRunning = true;
            _gameWon = false;
            previousRoom = null;
        }

        public static Game LoadFromFile(string gameFileName) => Load(File.ReadAllText(gameFileName));

        public static Game Load(string jsonString)
        {
            Game game = JsonConvert.DeserializeObject<Game>(jsonString);
            game.Player = game.World.SpawnPlayer();
            return game;
        }
        #endregion

        #region Input Handler
        private void Input_InputReceivedHandler(object sender, string commandString)
        {
            if (_gameWon)
            {
                WinGame(commandString);
            }
            else if (commandString == "")
                Output.WriteLine("Say what now?");
            else
            {
                commandString = commandString.ToUpper();
                _commandWords = SplitIntoMultipleWords(commandString);

                Commands foundCommand = null;
                foreach (Commands command in CommandsDictionary.Values)
                {
                    if (command.Verbs.Contains(_commandWords[0]))
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
                    Output.WriteLine("That's not a verb I recognize.");
                    Output.WriteLine(Player.Location);
                }
            }
        }
        #endregion

        #region Command Functions
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
            foreach(Item i in game.Player.Location.Items)
            {
                string identifier = CheckAOrAn(i.Name);
                game.Output.WriteLine($"There is {identifier} {i} here.");
            }
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

        private static void Inventory(Game game)
        {
            if (game.Player.Items.Count == 0)
                game.Output.WriteLine("You are empty-handed.");
            else
            {
                game.Output.WriteLine("You are carrying: ");
                foreach (Item item in game.Player.Items)
                {
                    string identifier = CheckAOrAn(item.Name);
                    game.Output.WriteLine($"{identifier} {item}");
                }
            }
        }

        private static void Take(Game game, List<string> words)
        {
            string itemName;
            if (words.Count == 1)
            {
                game.Output.WriteLine("*Takes Nothing*");
                return;
            }
            else if (words.Count > 2)
                itemName = game.CombineExtraWords(words);
            else
                itemName = words[1];

            int result = game.Player.Take(itemName);
            if (result == -1)
            {
                game.Output.WriteLine("You can't see any such thing.");
                game.Output.WriteLine(game.Player.Location);
            }
            else if(result == 0)
                game.DisplayRandomQuip();
            else
                game.Output.WriteLine("Taken.");
        }

        private static void Drop(Game game, List<string> words)
        {
            string itemName;

            if (words.Count == 1)
            {
                game.Output.WriteLine("*Drops Air*");
                return;
            }
            else if (words.Count > 2)
                itemName = game.CombineExtraWords(words);
            else
                itemName = words[1];

            int result = game.Player.Drop(itemName);
            if (result == -1)
            {
                game.Output.WriteLine("You can't see any such thing.");
                game.Output.WriteLine(game.Player.Location);
            }
            else if(result == 0)
                game.Output.WriteLine($"The {itemName.ToLower()} is already here.");
            else
                game.Output.WriteLine("Dropped.");
        }

        private static void Put(Game game, List<string> words)
        {
            string itemName, otherItem, del;

            if (words.Count == 1)
            {
                game.Output.WriteLine("*Puts Nothing Nowhere*");
                return;
            }
            else if (words.Count > 2)
            {
                itemName = game.FindItemsInWordListUsingInOrOnAsDelimiter(words, true, out del);
                otherItem = game.FindItemsInWordListUsingInOrOnAsDelimiter(words, false, out del);
            }
            else
            {
                itemName = words[1];
                game.Output.WriteLine($"*Puts {itemName} Nowhere*");
                return;
            }

            int result = game.Player.Put(itemName, otherItem, del);
            if (result == -1)
            {
                game.Output.WriteLine("You can't see any such thing.");
                game.Output.WriteLine(game.Player.Location);
            }
            else if (result == 0)
                game.Output.WriteLine($"You need to be holding {itemName.ToLower()} in order to put it somewhere.");
            else if (result == -2)
                game.Output.WriteLine($"You can't put things in there...");
            else if (result == 2)
                game.Output.WriteLine($"Putting the {itemName.ToLower()} on the {otherItem.ToLower()} isn't going to help anyone.");
            else if (result == -3)
                game.Output.WriteLine($"The {otherItem.ToLower()} needs to be open before you can put things in it.");
            else
            {
                game.Output.WriteLine($"You put the {itemName.ToLower()} in the {otherItem.ToLower()}.");
                game.CheckWinStatus();
            }
        }

        private static void Open(Game game, List<string> words)
        {
            string itemName;

            if (words.Count == 1)
            {
                game.Output.WriteLine("*Opens Nothing*");
                return;
            }
            else if (words.Count > 2)
                itemName = game.CombineExtraWords(words);
            else
                itemName = words[1];

            int result = game.Player.Open(itemName);
            if (result == -1)
            {
                game.Output.WriteLine("You can't see any such thing.");
                game.Output.WriteLine(game.Player.Location);
            }
            else if (result == 0)
                game.Output.WriteLine("That's already open.");
            else if(result == -2)
                game.Output.WriteLine("That's not something you can open");
            else
                game.Output.WriteLine("Opened.");
        }

        private static void Close(Game game, List<string> words)
        {
            string itemName;

            if (words.Count == 1)
            {
                game.Output.WriteLine("*Closes Nothing*");
                return;
            }
            else if (words.Count > 2)
                itemName = game.CombineExtraWords(words);
            else
                itemName = words[1];

            int result = game.Player.Close(itemName);
            if (result == -1)
            {
                game.Output.WriteLine("You can't see any such thing.");
                game.Output.WriteLine(game.Player.Location);
            }
            else if (result == 0)
                game.Output.WriteLine("That's already closed.");
            else if (result == -2)
                game.Output.WriteLine("That's not something you can close");
            else
                game.Output.WriteLine($"You close the {itemName.ToLower()}.");
        }
        #endregion

        #region Quips
        private void DisplayRandomQuip()
        {
            Random rnd = new Random();
            int index = rnd.Next(Quips.Count);
            Output.WriteLine(Quips[index]);
        }
#endregion

        #region AnalyzingInput
        private List<string> SplitIntoMultipleWords(string input)
        {
            int charIndex = 0, wordCount = 0;
            string currentWord = "";
            List<string> words = new List<string>();

            while (charIndex < input.Length)
            {
                if (input[charIndex] == ' ')
                {
                    words.Add(currentWord);
                    currentWord = "";
                    wordCount++;
                }
                else
                {
                    currentWord = currentWord + input[charIndex];
                }
                if(charIndex == input.Length - 1)
                {
                    words.Add(currentWord);
                    currentWord = "";
                    wordCount++;
                }
                charIndex++;
            }
            return words;
        }

        private string CombineExtraWords(List<string> words)
        {
            string input = "";
            for(int i=1; i<words.Count(); i++)
            {
                input = input + words[i];
                if (i != words.Count - 1)
                    input = input + " ";
            }
            return input;
        }

        private static string CheckAOrAn(string input)
        {
            string startingChar = input.Substring(0, 1);
            if (startingChar == "a" || startingChar == "e" || startingChar == "i" || startingChar == "o" || startingChar == "u") 
                return "an";
            else
                return "a";
        }

        private string FindItemsInWordListUsingInOrOnAsDelimiter(List<string> words, bool lookBefore, out string del) // The greatest function name ever
        {
            string itemName = "";
            int inIndex = FindInIndex(words, out del);

            if (lookBefore && inIndex != -1)
            {
                for (int i=1; i<inIndex; i++)
                {
                    itemName = itemName + words[i];
                    if (i != inIndex - 1)
                        itemName = itemName + " ";
                }
                return itemName;
            }
            else if(!lookBefore && inIndex != -1)
            {
                for (int i = inIndex+1; i < words.Count; i++)
                {
                    itemName = itemName + words[i];
                    if (i != words.Count - 1)
                        itemName = itemName + " ";
                }
                return itemName;
            }
            else
            {
                return null;
            }
        }

        private int FindInIndex(List<string> words, out string del)
        {
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] == "IN" || words[i] == "ON")
                {
                    del = words[i];
                    return i;
                }
            }
            del = "";
            return -1;
        }
        #endregion

        #region EndOfGame
        private void CheckWinStatus()
        {
            bool containsMat = false, containsEgg = false, containsChalice = false;
            foreach(Item i in Player.World.Rooms[2].Items[0].Items)
            { 
                switch(i.AlternativeName)
                {
                    case "mat":
                        containsMat = true;
                        break;
                    case "egg":
                        containsEgg = true;
                        break;
                    case "chalice":
                        containsChalice = true;
                        break;
                }
            }
            if(containsMat && containsEgg && containsChalice)
            {
                _gameWon = true;
                Output.WriteLine("\nCongratulations! You have beaten Zork!");
                Output.WriteLine("Would you like to play again? (y/n)");
            }
        }

        private void WinGame(string commandString)
        {
            if (commandString.ToUpper() == "Y")
            {
                ResetGame();
            }
            else if (commandString.ToUpper() == "N")
            {
                IsRunning = false;
                return;
            }
            else
            {
                Output.WriteLine("Invalid input, please put 'y' or 'n'");
            }
        }

        private void ResetGame()
        {
            IsResetting = true;
            IsRunning = false;
            Input.InputReceived -= Input_InputReceivedHandler;
        }
        #endregion

        #region Variables
        private Room previousRoom;
        private bool _isResetting;
        private bool _isRunning;
        private bool _gameWon;
        private List<string> _commandWords;
        #endregion
    }
}
