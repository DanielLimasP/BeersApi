using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace BeersApi.Models
{
    public class Beers
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int number { get; set; }
        public double alcohol_by_volume { get; set; }
        public int ibu { get; set; }
        public int beer_id { get; set; }
        [BsonElement("name")]
        [JsonProperty("name")]
        public string name { get; set; }
        public string style { get; set; }
        public int brewery_id { get; set; }
        public double ounces { get; set; }

    }
}
