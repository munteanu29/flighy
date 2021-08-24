using System;
using System.Collections.Generic;

namespace itec_backend.Entities
{
    public class ArtistEntity: Entity
    {
        public ArtistEntity(string name, string surname,string category, string avatar, string description, bool deleted, string id):   base(deleted, id)
        {
            Name = name;
            Surname = surname;
            Category = category;
            Avatar = avatar;
            Description = description;

        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string  Category { get; set; }
        public string Avatar { get; set; }
        public string Description { get; set; }
    }
}