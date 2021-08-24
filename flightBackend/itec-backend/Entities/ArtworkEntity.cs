using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace itec_backend.Entities
{
    public class ArtworkEntity: Entity
    {
        public ArtworkEntity(string name,string category,string artistId, string avatar, string description, bool deleted, string id):   base(deleted, id)
        {
            Name = name;
            Category = category;
            Avatar = avatar;
            Description = description;
            ArtistId = artistId;
        }
        public string Name { get; set; }
        public string  Category { get; set; }
        public string Avatar { get; set; }
        public string Description { get; set; }
        
        public string ArtistId { get; set; }
        [JsonIgnore]
        [ForeignKey(nameof(ArtistId))]
        public ArtistEntity Artist { get; set; }
    }
}