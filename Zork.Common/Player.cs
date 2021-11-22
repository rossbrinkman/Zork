﻿using Newtonsoft.Json;
using System;

namespace Zork
{
    public class Player
    {
        public event EventHandler<Room> LocationChanged;
        public event EventHandler<int> ScoreChanged;
        public event EventHandler<int> MovesChanged;

        public World World { get; }

        [JsonIgnore]
        public Room Location
        {
            get
            {
                return _location;
            }
            private set
            {
                if (_location != value)
                {
                    _location = value;
                    LocationChanged?.Invoke(this, _location) ;
                }
            }
        }

        public string LocationName
        {
            get { return Location?.Name; }
            set => Location = World?.RoomsByName.GetValueOrDefault(value);
        }

        public Player(World world, string startingLocation)
        {
            World = world;
            LocationName = startingLocation;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            if (isValidMove)
                Location = destination;
            return isValidMove;
        }

        public int score
        {
            get
            {
                return _score;
            }
            set
            {
                if (_score != value)
                {
                    _score = value;
                    ScoreChanged?.Invoke(this, _score);
                }
            }
        }
        public int moves {
            get
            {
                return _moves;
            }
            set
            {
                if (_moves != value)
                {
                    _moves = value;
                    MovesChanged?.Invoke(this, _moves);
                }
            }
        }

        private Room _location;
        private int _score;
        private int _moves;
    }
}
