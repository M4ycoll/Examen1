using System.Net;
using Microsoft.AspNetCore.Mvc;
using SuperHeroes.Models;

namespace SuperHeroes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuperHeroController : ControllerBase
    {
        ISuperHeroService SuperHeroService;
        public SuperHeroController(ISuperHeroService _SuperHeroService)
        {
            SuperHeroService = _SuperHeroService;
        }

        [HttpPost]
        public async Task<IActionResult> postSuperHero([FromBody] SuperHero newSuperHero)
        {
            await SuperHeroService.CreateAsync(newSuperHero);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(SuperHeroService.Get());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] SuperHero updSuperHero)
        {
            await SuperHeroService.Update(id, updSuperHero);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await SuperHeroService.Delete(id);
            return Ok();
        }
    }
}