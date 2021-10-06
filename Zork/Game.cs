﻿using Newtonsoft.Json;
using System;
using System.IO;


namespace Zork
{
    public class Game
    {
        public World World { get; private set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        private bool IsRunning { get; set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;
        }

        public void Run()
        {
            IsRunning = true;
            Room previousRoom = null;
            while (IsRunning)
            {
                Console.Write($"{Player.Location}\n");

                if (previousRoom != Player.Location)
                {
                    Console.Write($"{Player.Location.Description}\n\n> ");
                    previousRoom = Player.Location;
                }

                Commands command = ToCommand(Console.ReadLine().Trim());
                Player.moves++;

                switch (command)
                {
                    case Commands.QUIT:
                        IsRunning = false;
                        break;
                    case Commands.SCORE:
                        Console.WriteLine($"Your score would be {Player.score}, in {Player.moves} move(s).\n");
                        break;
                    case Commands.REWARD:
                        Player.score++;
                        Console.WriteLine("Player score +1\n");
                        break;
                    case Commands.LOOK:
                        Console.WriteLine(Player.Location.Description);
                        break;
                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = Enum.Parse<Directions>(command.ToString(), true);
                        if (!Player.Move(direction))
                            Console.WriteLine("The way is shut!\n");
                        break;
                    default:
                        --Player.moves;
                        Console.WriteLine("Unknown command\n");
                        break;
                }
            }
        }

        public static Game Load(string filename)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(filename));
            game.Player = game.World.SpawnPlayer();
            return game;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

    }
}
