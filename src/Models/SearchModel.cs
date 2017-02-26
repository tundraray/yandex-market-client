using System.Collections.Generic;
using Newtonsoft.Json;

namespace Apix.Sync.YaMarket.Models
{
    public class SearchResult
    {
        [JsonProperty(PropertyName = "redirect")]
        public Redirects Redirects { get; set; }
    }

    public class Redirects
    {
        [JsonProperty(PropertyName = "content")]
        public Content Content { get; set; }
    }

    public class Content
    {
        [JsonProperty(PropertyName = "items")]
        public List<SearchItem> Items { get; set; }

        [JsonProperty(PropertyName = "model")]
        public SearchItem Model { get; set; }
    }

    public class SearchItem
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
    }
}