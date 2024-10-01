using amateur_soccer_usa.Providers;
using Entities.DTO.League;
using Entities.Parameters;
using Microsoft.AspNetCore.Mvc;

namespace amateur_soccer_usa.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LeaguesController(ILeagueProvider leagueProvider) 
        : ControllerBase

    {
        [HttpGet("testing")]
        public async Task<IActionResult> Testing()
        {
            return Ok(await leagueProvider.Testing2());
        }

        [HttpGet(Name = "GetLeagues")]
        public async Task<IActionResult> GetAsync([FromQuery]LeagueParameters parameters)
        {
            return Ok(await leagueProvider.GetAsync(parameters));
        }

        [HttpPost(Name = "CreateLeague")]
        public async Task<IActionResult> CreateAsync([FromBody]LeagueCreateDTO createModel)
        {
            return Ok(await leagueProvider.CreateAsync(createModel));

            //if (User.Identity != null && User.Identity.Name != null)
            //{
            //    string name = User.Identity.Name;
            //    await leagueProvider.CreateAsync(createModel, name);

            //    return Ok();
            //}
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