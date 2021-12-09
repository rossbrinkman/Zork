using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zork
{
    public class Item
    {
        [JsonProperty]
        public string Name { get; private set; }

        [JsonProperty]
        public bool IsPickup { get; private set; }

        [JsonProperty]
        public bool CanCarryItems { get; private set; }

        [JsonProperty]
        public string AlternativeName { get; private set; }

        [JsonProperty]
        public List<Item> Items { get; private set; }

        [JsonProperty]
        public bool IsOpen { get; set; }

        [JsonProperty]
        public bool CanBeOpened { get; private set; }

        Item(){
            Items = new List<Item>();
        }

        public override string ToString() => Name;
    }
}
