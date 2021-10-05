using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    internal class Program
    {
        private static Room CurrentRoom
        {
            get
            {
                return Rooms[Location.Row, Location.Column];
            }
        }

        static void Main(string[] args)
        {
            const string defaultFileName = "Rooms.json";
            string roomsFileName = (args.Length > 0 ? args[(int)CommandLineArguments.RoomsFileName] : defaultFileName);
            InitializeRooms(roomsFileName);
            Console.WriteLine("Welcome to Zork!");

            Room previousRoom = null;
            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write($"{CurrentRoom}\n");

                if (previousRoom != CurrentRoom)
                {
                    Console.Write($"{CurrentRoom.Description}\n> ");
                    previousRoom = CurrentRoom;
                }

                command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        Console.WriteLine("Thank you for playing!");
                        break;
                    case Commands.LOOK:
                        Console.WriteLine(CurrentRoom.Description);
                        break;
                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        if(!Move(command))
                            Console.WriteLine("The way is shut!");
                        break;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

        private static bool IsDirection(Commands command) => Directions.Contains(command);

        private static bool Move(Commands command)
        {
            Assert.IsTrue(IsDirection(command), "Invalid Direction");

            bool didMove;
            switch (command)
            {
                case Commands.NORTH when Location.Row < Rooms.GetLength(0) - 1:
                    Location.Row++;
                    didMove = true;
                    break;
                case Commands.SOUTH when Location.Row > 0:
                    Location.Row--;
                    didMove = true;
                    break;
                case Commands.EAST when Location.Column < Rooms.GetLength(1) - 1:
                    Location.Column++;
                    didMove = true;
                    break;
                case Commands.WEST when Location.Column > 0:
                    Location.Column--;
                    didMove = true;
                    break;
                default:
                    didMove = false;
                    break;
            }
            return didMove;
        }

        private static void InitializeRooms(string roomsFileName) =>
            Rooms = JsonConvert.DeserializeObject<Room[,]>(File.ReadAllText(roomsFileName));

        private static Room[,] Rooms;

        private static readonly List<Commands> Directions = new List<Commands>()
        {
            Commands.NORTH,
            Commands.SOUTH,
            Commands.EAST,
            Commands.WEST
        };
        
        private enum Fields
        {
            Name,
            Description
        }

        private enum CommandLineArguments
        {
            RoomsFileName = 0
        }

        private static (int Row, int Column) Location = (1,1);
    }
}
