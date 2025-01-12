using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GhostbustersEchoServer.Jsons;

internal class ProgressionInventoryAll
{
    [JsonPropertyName("Inventory")]
    public InventoryClass Inventory { get; set; } = new();
    public class InventoryClass
    {
        [JsonPropertyName("AccountID")]
        public string AccountID { get; set; } = string.Empty;

        [JsonPropertyName("Items")]
        public Dictionary<string, Item> Items { get; set; } = [];
    }

    public class Item
    {
        [JsonPropertyName("AccountID")]
        public string AccountID { get; set; } = string.Empty;

        [JsonPropertyName("Acquired")]
        public DateTime Acquired { get; set; }

        [JsonPropertyName("Attributes")]
        public Dictionary<object, object> Attributes { get; set; } = [];

        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("ID")]
        public string ID { get; set; } = string.Empty;

        [JsonPropertyName("MetaID")]
        public string MetaID { get; set; } = string.Empty;

        [JsonPropertyName("Tags")]
        public List<string> Tags { get; set; } = [];
    }
}
