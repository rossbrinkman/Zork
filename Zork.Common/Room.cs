using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System;

namespace Zork
{
    public class Room : INotifyPropertyChanged, IEquatable<Room>
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty(Order = 1)]
        public string Name { get; set; }
        [JsonProperty(Order = 2)]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "Neighbors", Order = 3)]
        private Dictionary<Directions, string> NeighborNames { get; set; }

        [JsonIgnore]
        public Dictionary<Directions, Room> Neighbors { get; private set; }

        public static bool operator ==(Room lhs, Room rhs)
        {
            if (ReferenceEquals(lhs, rhs))
                return true;
            if (lhs is null || rhs is null)
                return false;

            return lhs.Name == rhs.Name;
        }

        public Room(string name = null)
        {
            Name = name;
        }

        public static bool operator !=(Room lhs, Room rhs) => !(lhs == rhs);


        public override bool Equals(object obj) => obj is Room room && this == room;

        public bool Equals(Room other) => this == other;

        public override string ToString() => Name;

        public override int GetHashCode() => Name.GetHashCode();

        //[JsonIgnore]
        //public Room DefaultRoom { get; set; }

        //[JsonProperty(PropertyName = "DefaultRoom")]
        //public string DefaultRoomName { get; set; }

        //[JsonProperty(PropertyName = "Inventory")]
        //private List<string> InventoryNames { get; set; }

        //[JsonIgnore]
        //public List<Room> Inventory { get; set; }

        //private Dictionary<Directions, string> DirectionNames { get; set; }

        //public void BuildInventoryFromNames(List<Room> rooms)
        //{
        //    DefaultRoom = rooms.Find(i => i.Name.Equals(DefaultRoomName, StringComparison.InvariantCultureIgnoreCase));

        //    Inventory = (from itemName in InventoryNames
        //                 let item = rooms.Find(i => i.Name.Equals(itemName, StringComparison.InvariantCultureIgnoreCase))
        //                 where item != null
        //                 select item).ToList();

        //    InventoryNames.Clear();
        //}

        public void UpdateNeighbors(World world)

            => Neighbors = (from entry in NeighborNames
                            let room = world.RoomsByName.GetValueOrDefault(entry.Value) /*rooms.Find(i => i.Name.Equals(entry.Value, StringComparison.InvariantCultureIgnoreCase))*/
                            where room != null
                            select (Direction: entry.Key, Room: room))
                            .ToDictionary(pair => pair.Direction, pair => pair.Room);
    }
}
