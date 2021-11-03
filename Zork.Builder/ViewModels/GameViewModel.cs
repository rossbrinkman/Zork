﻿using System;
using System.ComponentModel;
using System.IO;
using Zork.Builder;
using Newtonsoft.Json;

namespace Zork.Builder.ViewModels
{
    internal class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool GameIsLoaded { get; set; }

        //public BindingSource World { get; set; };

        public BindingList<Room> Rooms
        {
            get => rooms;
            set
            {
                if (rooms != value)
                {
                    rooms = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Rooms)));
                }
            }
        }

        public Game Game
        {
            set
            {
                if (_game != value)
                {
                    _game = value;
                    if (_game != null)
                    {
                        Rooms = new BindingList<Room>(_game.World.Rooms);
                        //startingLocationComboBox.DataSource = _game.World.StartingLocation;
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                        //World = new BindingSource(_game.World);
                    }
                }
            }
        }

        public GameViewModel(Game game = null) => Game = game;

        public void SaveGame(string filename)
        {
            if (!GameIsLoaded)
            {
                throw new InvalidOperationException("No game loaded.");
            }

            if (string.IsNullOrWhiteSpace(filename))
            {
                throw new InvalidProgramException("Invalid filename.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };

            using (StreamWriter streamWriter = new StreamWriter(filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, _game);
            }
        }

        private Game _game;
        private BindingList<Room> rooms;
    }
}
