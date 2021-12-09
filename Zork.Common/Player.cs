using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Zork
{
    public class Player
    {
        public event EventHandler<Room> LocationChanged;
        public event EventHandler<int> ScoreChanged;
        public event EventHandler<int> MovesChanged;

        public World World { get; }

        public List<Item> Items { get; set; }

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
            Items = new List<Item>();
        }

        #region Command Functions
        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            if (isValidMove)
                Location = destination;
            return isValidMove;
        }

        public int Take(string itemName)
        {
            Item foundItem = IsItemInList(Location.Items, itemName);
            if (foundItem == null)
            {
                foreach (Item i in Location.Items)
                {
                    if (i.IsOpen)
                    {
                        foundItem = IsItemInList(i.Items, itemName);
                        i.Items.Remove(foundItem);
                    }
                }
            }
            if (foundItem == null)
            {
                foreach (Item i in Items)
                {
                    if (i.IsOpen)
                    {
                        foundItem = IsItemInList(i.Items, itemName);
                        i.Items.Remove(foundItem);
                    }
                }
            }

            if (foundItem != null && foundItem.IsPickup)
            {
                Items.Add(foundItem);
                Location.Items.Remove(foundItem);
                return 1;
            }
            else if (foundItem != null && !foundItem.IsPickup)
                return 0;
            return -1;
        }

        public int Drop(string itemName)
        {
            Item foundItem = IsItemInList(Items, itemName);
            if (foundItem != null)
            {
                Location.Items.Add(foundItem);
                Items.Remove(foundItem);
                return 1;
            }
            else
            {
                foundItem = IsItemInList(Location.Items, itemName);
                if (foundItem != null)
                    return 0;
            }
            return -1;
        }

        public int Open(string itemName)
        {
            Item foundItem = IsItemInList(Items, itemName);
            if(foundItem == null)
                foundItem = IsItemInList(Location.Items, itemName);

            if (foundItem != null && !foundItem.CanBeOpened)
                return -2;
            else if (foundItem != null && !foundItem.IsOpen)
            {
                foundItem.IsOpen = true;
                return 1;
            }
            else if(foundItem != null)
                return 0;
            return -1;
        }

        public int Close(string itemName)
        {
            Item foundItem = IsItemInList(Items, itemName);
            if (foundItem == null)
                foundItem = IsItemInList(Location.Items, itemName);

            if (!foundItem.CanBeOpened)
                return -2;
            else if (foundItem != null && foundItem.IsOpen)
            {
                foundItem.IsOpen = false;
                return 1;
            }
            else if (foundItem != null)
                return 0;
            return -1;
        }

        public int Put(string itemName, string otherItem, string del)
        {
            Item foundItem = IsItemInList(Items, itemName);
            Item foundItem2 = IsItemInList(Location.Items, otherItem);
            if(foundItem2 == null)
                foundItem2 = IsItemInList(Items, otherItem);

            if (foundItem != null && foundItem2 != null && del == "ON")
                return 2;
            else if (foundItem != null && foundItem2 != null && foundItem2.CanCarryItems && foundItem2.IsOpen)
            {
                foundItem2.Items.Add(foundItem);
                Items.Remove(foundItem);
                return 1;
            }
            else if (foundItem != null && foundItem2 != null && foundItem2.CanCarryItems && !foundItem2.IsOpen)
                return -3;
            else if (foundItem != null && foundItem2 != null && !foundItem2.CanCarryItems)
                return -2;
            else
            {
                foundItem = IsItemInList(Location.Items, itemName);
                if (foundItem != null)
                    return 0;
            }
            return -1;
        }
        #endregion

        private Item IsItemInList(List<Item> itemList, string itemName)
        {
            foreach(Item item in itemList)
            {
                if (item.Name.ToUpper() == itemName || item.AlternativeName.ToUpper() == itemName)
                    return item;
            }
            return null;
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
