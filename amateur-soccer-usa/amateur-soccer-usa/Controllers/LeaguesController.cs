using amateur_soccer_usa.Providers;
using Entities.DTO.League;
using Entities.Parameters;
using Microsoft.AspNetCore.Mvc;

namespace amateur_soccer_usa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaguesController(ILeagueProvider leagueProvider) : ControllerBase
    {
        [HttpGet(Name = "GetLeagues")]
        public async Task<IActionResult> GetAsync([FromQuery]LeagueParameters parameters)
        {
            return Ok(await leagueProvider.GetAsync(parameters));
        }

        [HttpPost(Name = "CreateLeague")]
        public async Task<IActionResult> CreateAsync([FromBody]LeagueCreateDTO createModel)
        {
            await leagueProvider.CreateAsync(createModel);

            return NoContent();
        }

        [HttpPut(Name = "UpdateLeague")]
        public async Task<IActionResult> UpdateAsync([FromBody]LeagueUpdateDTO updateModel)
        {
            await leagueProvider.UpdateAsync(updateModel);

            return NoContent();
        }

        [HttpDelete(Name = "DeleteLeague")]
        public async Task<IActionResult> DeleteAsync([FromBody]int leagueId)
        {
            await leagueProvider.DeleteAsync(leagueId);

            return NoContent();
        }
    }
}