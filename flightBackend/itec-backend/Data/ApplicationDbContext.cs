using itec_backend.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace itec_backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ArtistEntity> ArtistEntities { get; set; }
        public DbSet<ArtworkEntity> ArtworkEntities { get; set; }


        public IRepository<T> GetRepository<T>() where T : Entity
        {
            return new Repository<T>(this);
        }
    }
}