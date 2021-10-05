using System;
using System.Collections.Generic;
using System.IO;

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
            const string defaultFileName = "Rooms.txt";
            string roomsFileName = (args.Length > 0 ? args[(int)CommandLineArguments.RoomsFileName] : defaultFileName);
            InitializeRoomDescriptions(roomsFileName);
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

        static Program()
        {
            RoomMap = new Dictionary<string, Room>();

            foreach (Room room in Rooms)
            {
                RoomMap[room.Name] = room;
            }
        }

        private static readonly Dictionary<string, Room> RoomMap;

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

        private static void InitializeRoomDescriptions(string roomsFileName)
        {
            string[] lines = File.ReadAllLines(roomsFileName);

            foreach (string line in lines)
            {
                const string delimiter = "##";
                const int expectedFieldCount = 2;

                string[] fields = line.Split(delimiter);
                Assert.IsTrue(fields.Length == expectedFieldCount, "Invalid Record");

                (string name, string description) = (fields[(int)Fields.Name], fields[(int)Fields.Description]);

                RoomMap[name].Description = description;
            }
        }

        private static readonly Room[,] Rooms = {
              { new Room("Rocky Trail"),  new Room("South of House"),  new Room("Canyon View")},
              { new Room("Forest"),       new Room("West of House"),   new Room("Behind House") },
              { new Room("Dense Woods"),  new Room("North of House"),  new Room("Clearing") }
        };

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
