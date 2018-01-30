using System;
using Newtonsoft.Json;

namespace Marketplace.API.Domain.Domain
{
    public class Marketplace
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "social_reason")]
        public string SocialReason { get; set; }

        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "location_maps")]
        public string LocationMaps { get; set; }

        [JsonProperty(PropertyName = "phone")]
        public int Phone { get; set; }

        [JsonProperty(PropertyName = "photo")]
        public string Photo { get; set; }

    }
}
