using amateur_soccer_usa.Providers;
using Entities.Database;
using Microsoft.AspNetCore.Mvc;

namespace amateur_soccer_usa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching", "Drippin'"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ILeagueProvider _leagueProvider;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ILeagueProvider leagueProvider)
        {
            _logger = logger;
            _leagueProvider = leagueProvider;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet(Name = "GetTesting")]
        public async Task<IActionResult> GetTesting()
        {
            return Ok(await _leagueProvider.GetAllLeaguesAsync());
        }
    }
}
