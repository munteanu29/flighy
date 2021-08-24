using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itec_backend.Data;
using itec_backend.Entities;
using itec_backend.Models;
using Microsoft.AspNetCore.Authorization;
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
        [AllowAnonymous]
        [ProducesResponseType(typeof(IEnumerable<ArtistEntity>), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public async Task<IActionResult> GetArtistInfo(string id)
        {
           
            var artistEntity = _artistEntity.Queryable.FirstOrDefault(t =>
                String.Equals(t.Id, id, StringComparison.CurrentCultureIgnoreCase));
            
            var response = new ArtistModel
            {
                Name = artistEntity.Name,
                Surname = artistEntity.Surname,
                Avatar = artistEntity.Avatar,
                Category = artistEntity.Category,
                Description = artistEntity.Description
            };
            return Ok(response);
        }
        
        [HttpGet("GetArtists")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IEnumerable<ArtistEntity>), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public async Task<IActionResult> GetArtists()
        {
           
          
            var artists =  _artistEntity.Queryable.Where(t=>!String.IsNullOrEmpty(t.Name));
            return Ok(artists);
        }
        
        [HttpPost("AddArtists")]
        public async Task<IActionResult> AddArtists([FromBody] ArtistModel artistModel)
        {
            var artist = new ArtistEntity(artistModel.Name, artistModel.Surname,artistModel.Category,artistModel.Avatar, artistModel.Description,  false, Guid.NewGuid().ToString());
            await _artistEntity.AddAsync(artist);
            return Ok();
        }
        
        

     
    };
}