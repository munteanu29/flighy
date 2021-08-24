using itec_backend.Entities;

namespace itec_backend.Models
{
    public class WorkartModel
    {
        public string Name { get; set; }
        public string  Category { get; set; }
        public string Avatar { get; set; }
        public string Description { get; set; }
        
        public string ArtistId { get; set; }
    }
}