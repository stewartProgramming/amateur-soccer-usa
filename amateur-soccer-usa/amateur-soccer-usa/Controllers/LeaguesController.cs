using amateur_soccer_usa.Providers;
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
    }
}
