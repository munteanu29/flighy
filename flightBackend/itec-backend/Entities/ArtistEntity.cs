using System;
using System.Collections.Generic;

namespace itec_backend.Entities
{
    public class ArtistEntity: Entity
    {
        public ArtistEntity(string name, string surname, bool deleted, string id):   base(deleted, id)
        {
            Name = name;
            Surname = surname;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}