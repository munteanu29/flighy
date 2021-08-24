using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itec_backend.Data;
using itec_backend.Entities;
using itec_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace itec_backend.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [ProducesResponseType(typeof(UnauthorizedResult), 401)]
    public class ArtistController : Controller
    {
        private readonly IRepository<ArtistEntity> _artistEntity;

        public ArtistController(ApplicationDbContext context)
        {
            _artistEntity = context.GetRepository<ArtistEntity>();
        }


        [HttpGet("GetArtist")]
        [ProducesResponseType(typeof(IEnumerable<ArtistEntity>), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public async Task<IActionResult> GetCountryInfo(string name, string surname)
        {
           
            var countryEntity = _artistEntity.Queryable.FirstOrDefault(t =>
                String.Equals(t.Name, name, StringComparison.CurrentCultureIgnoreCase));
            
            var response = new ArtistModel
            {
                Name = countryEntity.Name,
                Surname = countryEntity.Surname
            };
            return Ok(response);
        }

     
    };
}