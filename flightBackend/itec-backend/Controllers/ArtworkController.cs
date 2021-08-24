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
using Microsoft.EntityFrameworkCore;

namespace itec_backend.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [ProducesResponseType(typeof(UnauthorizedResult), 401)]
    public class ArtworkController : Controller
    {
        private readonly IRepository<ArtworkEntity> _workartEntity;
        private readonly IRepository<ArtistEntity> _artistEntity;


        public ArtworkController(ApplicationDbContext context)
        {
            _workartEntity = context.GetRepository<ArtworkEntity>();
            _artistEntity = context.GetRepository<ArtistEntity>();
        }
        

        [HttpGet("GetWorkart")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IEnumerable<ArtworkEntity>), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public async Task<IActionResult> GetWorkart(string id)
        {
            if (id == null)
                return BadRequest("id null");
            var artistEntity = _workartEntity.Queryable.FirstOrDefault(t =>
                String.Equals(t.Id, id, StringComparison.CurrentCultureIgnoreCase));

            if (artistEntity == null)
                return BadRequest("artist not found");
            
           
            return Ok(artistEntity);
        }
        
        [HttpGet("GetWorkarts")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IEnumerable<ArtworkEntity>), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public async Task<IActionResult> GetWorkarts()
        {
           
          
            var workArts =  _workartEntity.Queryable.Where(t=>!String.IsNullOrEmpty(t.Name)).Include(t=>t.Artist);
            
            return Ok(workArts);
        }
        
        [HttpPost("AddWorkarts")]
        public async Task<IActionResult> AddWorkarts([FromBody] WorkartModel  workartModel)
        {
            var workArt = new ArtworkEntity(workartModel.Name, workartModel.Category, workartModel.ArtistId,workartModel.Avatar, workartModel.Description , false, Guid.NewGuid().ToString());
            await _workartEntity.AddAsync(workArt);
            return Ok();
        }
        
        

     
    };
}
